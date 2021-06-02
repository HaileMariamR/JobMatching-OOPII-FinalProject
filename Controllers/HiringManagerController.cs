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
using SweetAlertEnum;


namespace JobMatching_OOPII_FinalProject.Controllers
{
    public class HiringManagerController : CustomClaims
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
                    job.dateTime = DateTime.Now;
                 
                    job.userEmail = value.ToString();
                 
                    _database.jobs.Add(job);
                 
                     _database.SaveChanges();
                    Alert(NotificationType.success , "You have Post a jobz" , "Posted!");

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
            
            
             var alljobsRelatedtoCurrentuser = _database.jobs.Where(x => x.userEmail == value.ToString()).ToList();
           
             if (alljobsRelatedtoCurrentuser == null){
                 return View();
             }
             alljobsRelatedtoCurrentuser.Reverse();
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
                            
                            //        var userIdentity = new ClaimsIdentity(new[] {
                             
                            //     new Claim(ClaimTypes.Name , hiringManager.Email)
                           
                            // } , CookieAuthenticationDefaults.AuthenticationScheme);
                          
                            // var principal = new ClaimsPrincipal(userIdentity);
                         
                            // var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme , principal);
                            addAuthentication(hiringManager.Email);
                             Alert(NotificationType.success , "You have successfully Registered  as Hiring Manager" , "Registerd!");
                           
                             return RedirectToAction("HiringIndex" , "HiringManager" , new {userEmailAdress=hiringManager.Email.ToString()});

            
                        }else{
                            Alert(NotificationType.info , "The user  has already registered!" , "Sorry!");

                            return RedirectToAction("HiringManagerSignup" , "HiringManager");
                        
                        }
 


                    }catch(Exception ex){
                        Console.Write($"Error : {ex.Message}");

                    }
                

                     return View(hiringManager);

        }

        public IActionResult ApplicationsDashboard(){

             var currentEmployee    = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name);
            //  _logger.LogInformation(currentUserjobs.CompanyName.ToString());
  
         var ApplicantsApplications= _database.employeeApplications.
                                        Where(value => value.jobOwnerEmail ==currentEmployee.ToString()).ToList();
            
            if (ApplicantsApplications == null){
                return View();
            }

            _logger.LogInformation(ApplicantsApplications.ToString());
           
            ApplicantsApplications.Reverse();
          
            return View(ApplicantsApplications);
        }

        public IActionResult ViewApplicant(){

            //  var jobtitle = HttpContext.Request.Query["jTitle"].ToString();
          
            // var companyname=HttpContext.Request.Query["companyName"].ToString();
            var employeeEmail=HttpContext.Request.Query["EmployeeEmail"].ToString();

             var jobtitle = HttpContext.Request.Query["jTitle"].ToString();
             var companyname=HttpContext.Request.Query["companyName"].ToString();

                ViewData["jobtitle"] =jobtitle;
                ViewData["companyname"] =companyname;
                ViewData["EmployeeEmail"] =employeeEmail;


        
            var employeeInfo = _database.users.Where(value => value.Email==employeeEmail).FirstOrDefault();
            
            if(employeeInfo == null){
                return View();
            }
            return View(employeeInfo);
        }

        [HttpPost]
            public IActionResult ViewApplicant(String Accept , String Reject){


             var jobtitle = HttpContext.Request.Query["jobtitle"].ToString();
             var companyname=HttpContext.Request.Query["companyname"].ToString();
             var employeeEmail=HttpContext.Request.Query["emploeeEmail"].ToString();




                if(!string.IsNullOrEmpty(Accept))
                {
                      
                      var checkApplication = _database.employeeApplications
                                
                                    .Where(x => (x.ComapanyName==companyname) &&
                                    
                                                (x.Jobtitle==jobtitle)&&
                                   
                                                (x.EmployeeEmail ==employeeEmail)
                               
                                           ).FirstOrDefault();
                        if (checkApplication != null){

                            checkApplication.status = true;      
                            _logger.LogInformation(checkApplication.status.ToString());             

                            _database.SaveChanges();
                            Alert(NotificationType.success , $"You have recieved the application of {employeeEmail}" , "Recived Application!");

                        }

                    

                }
                if (!string.IsNullOrEmpty(Reject))
                {
                    _logger.LogInformation(Reject);

                }
         
            return RedirectToAction("ApplicationsDashboard" , "HiringManager");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

