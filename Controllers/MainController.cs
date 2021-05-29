using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JobMatching_OOPII_FinalProject.Models;
using ProjectContext.Data;
using Microsoft.AspNetCore.Authorization;
using Models.projectModels;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
namespace JobMatching_OOPII_FinalProject.Controllers
{

    // [Authorize]
    public class MainController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ProjectDatabaseContext _database;

        public MainController(ILogger<HomeController> logger , ProjectDatabaseContext p)
        {
            _logger = logger;
            _database = p;
        }
        

        public IActionResult MainIndex()
        {
            var allJobs = _database.jobs.ToList();
            allJobs.Reverse();
            
            _logger.LogInformation(allJobs.ToString());
         
            return View(allJobs);
        }


        public IActionResult Resume(){
             var CurrentEmployeeUser = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name);
           
             var UserInfo = _database.applicants.Where(x => x.Email == CurrentEmployeeUser.Value.ToString()).FirstOrDefault();
           
             if (UserInfo == null){
                 return View();
             }
            return View(UserInfo);
        }

        public IActionResult EditResume(){
        

            return View();
        }

        [HttpPost]
        public IActionResult EditResume(Applicants applicantsResume){
                if (ModelState.IsValid){
                try{

                     var CurrentEmployeeUser = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name);
                    var UserInfo = _database.applicants.Where(x => x.Email == CurrentEmployeeUser.Value.ToString()).FirstOrDefault();

                    UserInfo.JobPostion = applicantsResume.JobPostion;
                  
                    UserInfo.LinkedInLink = applicantsResume.LinkedInLink;
                    _database.SaveChanges();

                    return RedirectToAction("Resume" , "Main");
                    
                }catch(Exception ex){
                    Console.Write($"{ex.Message}");

                }   
            }
            
            return View();
        }


        public IActionResult JobDetail(){
            var jobtitle = HttpContext.Request.Query["JobTitle"].ToString();
          
            var companyname=HttpContext.Request.Query["Companyname"].ToString();
           
            var jobdetail = _database.jobs.Where(x => x.CompanyName == companyname & x.JobTitle ==jobtitle).FirstOrDefault();
           
            var numberofApplicants = _database.employeeApplications.Where(x => x.ComapanyName == companyname && x.Jobtitle ==jobtitle).ToList();
          
            ViewData["NumberofApplicants"] = numberofApplicants.Count.ToString();
            return View(jobdetail);
        }
        [HttpPost]
        public IActionResult JobDetail(Job job){

            var currentEmployee = HttpContext.Request.Query["user"].ToString();
          
            var companyName = HttpContext.Request.Query["CompanyName"].ToString();
          
            var jobTitle = HttpContext.Request.Query["JobTitle"].ToString();

            var getJobOwnerEmail = _database.jobs.Where(x=>x.CompanyName == companyName && x.JobTitle ==jobTitle).FirstOrDefault();

            var employee= new EmployeeApplication();
           
            employee.ComapanyName = companyName;
          
            employee.Jobtitle = jobTitle;
           
            employee.EmployeeEmail = currentEmployee;
          
            employee.DateofApplication = DateTime.Now;
            employee.jobOwnerEmail = getJobOwnerEmail.userEmail;
            
            var checkApplication = _database.employeeApplications
                                
                                    .Where(x => (x.ComapanyName==companyName) &&
                                    
                                                (x.Jobtitle==jobTitle)&&
                                   
                                                (x.EmployeeEmail ==currentEmployee)
                               
                                           ).FirstOrDefault();

            if(checkApplication ==null){

                try
                {
                    _database.employeeApplications.Add(employee);
             
                    _database.SaveChanges();

                    return RedirectToAction("MainIndex" , "Main");  
                    
                }
                catch(Exception ex){
               
                    Console.Write($"{ex.Message}");

                }


            }else{
                // _logger.LogInformation("" + checkApplication..ToString());

                Console.Write(checkApplication);
                
                return Content("u have already Applied!");
            }





            return View();
        }
        public IActionResult GetEmployeeApplications(){
             var currentEmployee    = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name);
    
            var currentUserApplications = _database.employeeApplications.Where(x=>x.EmployeeEmail == currentEmployee.Value.ToString()).ToList();
      
            return View(currentUserApplications);

         
        }




        public IActionResult NewjobRelatedtoEmployee(){
             var value = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name);
           
             var currentUser = _database.applicants.Where(x => x.Email == value.Value.ToString()).FirstOrDefault();
            //  _logger.LogInformation(currentUser.JobPostion.ToString());

            var jobrelatedtocurrentUser = _database.jobs.Where(value =>value.JobTitle == currentUser.JobPostion ).ToList();
           
            jobrelatedtocurrentUser.Reverse();
            // _logger.LogInformation(jobrelatedtocurrentUser.Count.ToString());
            return View(jobrelatedtocurrentUser);
        }

        public IActionResult ApplicationDetail(){

             var jobtitle = HttpContext.Request.Query["jTitle"].ToString();
          
            var companyname=HttpContext.Request.Query["cName"].ToString();
           
           
            var ApplicationDetail = _database.employeeApplications.Where(x => x.ComapanyName == companyname && x.Jobtitle ==jobtitle).ToList();
            ViewData["NumberofApplicants"] = ApplicationDetail.Count.ToString();

            var application = _database.employeeApplications.Where(x => x.ComapanyName == companyname && x.Jobtitle ==jobtitle).FirstOrDefault();

            
            return View(application);
            
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
