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


namespace JobMatching_OOPII_FinalProject.Controllers
{
    public class AdminController : Controller
    {

        private ProjectDatabaseContext _projectDatabaseContext;
        public AdminController(ProjectDatabaseContext projectdatabasecontext){
            _projectDatabaseContext =projectdatabasecontext;

        }

        
        public IActionResult AdminIndex()
        {
            return View();

        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}

