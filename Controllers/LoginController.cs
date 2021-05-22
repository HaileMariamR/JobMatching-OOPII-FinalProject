using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JobMatching_OOPII_FinalProject.Models;
using Models.projectModels;
using ProjectContext.Data;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;


namespace JobMatching_OOPII_FinalProject.Controllers
{
    public class LoginController : Controller
    {

        private ProjectDatabaseContext _database;
        public LoginController(ProjectDatabaseContext projectdatabasecontext){
            _database =projectdatabasecontext;

        }

        
       

    
        [HttpPost]
         public IActionResult Signin(Login loginvalue)
        {
            var userApplicant = _database.applicants.Where( value => value.Email == loginvalue.Email).FirstOrDefault();
            var hiringmanager_one = _database.hiringManagers.Where(value =>value.Email == loginvalue.Email).FirstOrDefault();


            if (loginvalue.Email == "admin@gmail.com" & loginvalue.Password =="admin"){
                return RedirectToAction("AdminIndex" , "Admin");
            }
            else if (userApplicant !=null){
                
                if((userApplicant.Email.ToString()==loginvalue.Email) & (userApplicant.Password.ToString()== loginvalue.Password)){
                        
                            var userIdentity = new ClaimsIdentity(new[] {
                                new Claim(ClaimTypes.Name , userApplicant.Email)
                            } , CookieAuthenticationDefaults.AuthenticationScheme);
                            var principal = new ClaimsPrincipal(userIdentity);
                            var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme , principal);


                             return RedirectToAction("MainIndex" , "Main");
                }
            }
            else if (hiringmanager_one !=null){
                  if((hiringmanager_one.Email.ToString()==loginvalue.Email) & (hiringmanager_one.Password.ToString() == loginvalue.Password)){


                               
                            var userIdentity = new ClaimsIdentity(new[] {
                                new Claim(ClaimTypes.Name , hiringmanager_one.Email)
                            } , CookieAuthenticationDefaults.AuthenticationScheme);
                            var principal = new ClaimsPrincipal(userIdentity);
                            var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme , principal);


                             return RedirectToAction("HiringIndex" , "HiringManager");

                }
            }else{
                return Content("Invalid  Email or password !");
            }

            return View(loginvalue);

        }

        



        public IActionResult Signin()
        {
            return View();
        }
        [HttpPost]
        
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}

