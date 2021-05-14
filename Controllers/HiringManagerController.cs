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
    public class HiringManagerController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ProjectDatabaseContext _database;

        public HiringManagerController(ILogger<HomeController> logger , ProjectDatabaseContext p)
        {
            _logger = logger;
            _database = p;
        }
        
        public IActionResult PostJob(){
            return View();
        }
        [HttpPost]
        public  IActionResult PostJob(Job job){
            if(ModelState.IsValid){
                try{    

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
            return View();
        }
        public IActionResult HiringManagerSignup()
        {
            return View();
        }
        [HttpPost]
            public IActionResult HiringManagerSignup(HiringManager hiringManager)
        {

                if (ModelState.IsValid){
                    try{
                            _database.hiringManagers.Add(hiringManager);
                             _database.SaveChanges();
                             return RedirectToAction("HiringIndex" , "HiringManager");

                    }catch(Exception ex){
                        Console.Write($"Error : {ex.Message}");

                    }
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
