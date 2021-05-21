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
            MainIndexModels mainIndexModels = new MainIndexModels();
            mainIndexModels.mainIndexjobs = allJobs;
            return View(mainIndexModels);
        }

//  [HttpPost]
//         public IActionResult Edit(Product product)
//         {
//             db.Entry(product).State = EntityState.Modified;
//             db.SaveChanges();
//             return RedirectToAction("Index");
//         }

//     }
// }

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
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
