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

namespace JobMatching_OOPII_FinalProject.Controllers
{
    public class ApplicantsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ProjectDatabaseContext _database;

        public ApplicantsController(ILogger<HomeController> logger , ProjectDatabaseContext p)
        {
            _logger = logger;
            _database = p;
        }
        

        public IActionResult ApplicantSignup()
        {
            return View();
        }
        [HttpPost]
            public IActionResult ApplicantSignup(Applicants applicants)
        {

                if (ModelState.IsValid){
                    try{
                            _database.applicants.Add(applicants);
                             _database.SaveChanges();
                             return RedirectToAction("MainIndex" , "Main");

                    }catch(Exception ex){
                        Console.Write($"Error : {ex.Message}");

                    }
                }

            return View(applicants);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
