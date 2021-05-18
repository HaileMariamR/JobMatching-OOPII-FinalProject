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




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
