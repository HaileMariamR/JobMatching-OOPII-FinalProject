using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JobMatching_OOPII_FinalProject.Models;
using Models.projectModels;
using Microsoft.EntityFrameworkCore;
using ProjectContext.Data;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace JobMatching_OOPII_FinalProject.Controllers
{
    public class HiringManagerController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ProjectDatabaseContext _database;

        public HiringManagerController(ILogger<HomeController> logger , ProjectDatabaseContext p)
        {
            _logger = logger;
            _database = p;
        }


        public IActionResult Logout()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index" , "Home");
        }
        
        public IActionResult PostJob(){
            return View();
        }


        [HttpPost]
        public  IActionResult PostJob(Job job){
             var value = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name);

            if(ModelState.IsValid){
                try{    
                 
                    job.userEmail = value.ToString();
                    _database.jobs.Add(job);
                     _database.SaveChanges();
                    return RedirectToAction("HiringIndex" , "HiringManager");
                    
                }
                catch(Exception ex){
                    Console.Write($"Error : {ex.Message}");
                }
            }
            return View(job);
        }
        public IActionResult HiringIndex(){

             var value = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name);
            
            
             var alljobsRelatedtoCurrentuser = _database.jobs.Where(x => x.userEmail == value.ToString());
             if (alljobsRelatedtoCurrentuser == null){
                 return View();
             }
            return View(alljobsRelatedtoCurrentuser);
        }   
        public IActionResult HiringManagerSignup()
        {
            return View();
        }
        [HttpPost]
            public IActionResult HiringManagerSignup(HiringManager hiringManager)
        {

            
                    try{
                        
                       
                        var hiringmanager_one = _database.hiringManagers.Where(value =>value.Email == hiringManager.Email).FirstOrDefault();
                        if (hiringmanager_one == null){
                            
                                _database.hiringManagers.Add(hiringManager);
                             _database.SaveChanges();
                            
                                   var userIdentity = new ClaimsIdentity(new[] {
                                new Claim(ClaimTypes.Name , hiringManager.Email)
                            } , CookieAuthenticationDefaults.AuthenticationScheme);
                            var principal = new ClaimsPrincipal(userIdentity);
                            var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme , principal);

                           
                             return RedirectToAction("HiringIndex" , "HiringManager" , new {userEmailAdress=hiringManager.Email.ToString()});

            
                        }else{
                            return Content("user already exist!");
                        
                        }
 


                    }catch(Exception ex){
                        Console.Write($"Error : {ex.Message}");

                    }
                

                     return View(hiringManager);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

