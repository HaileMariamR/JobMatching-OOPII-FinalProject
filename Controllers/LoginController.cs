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
    public class LoginController : Controller
    {

        private ProjectDatabaseContext _projectDatabaseContext;
        public LoginController(ProjectDatabaseContext projectdatabasecontext){
            _projectDatabaseContext =projectdatabasecontext;

        }

        
        public IActionResult Signin()
        {
            return View();

        }

        // [HttpPost]
        //  public IActionResult Signin(Login login)
        // {

        //     if (login.Email == "admin@gmail.com" & login.Password =="admin"){
        //         return RedirectToAction("AdminIndex" , "Admin");
        //     }
        //    else if (login.Email == "user@gmail.com" & login.Password =="user"){
        //         return RedirectToAction("MainIndex" , "Mainpage");
        //     }
        //      else if (login.Email == "hiringmanager@gmail.com" & login.Password =="hiringmanager"){
        //         return RedirectToAction("HiringManager" , "Mainpage");
        //     }
            
        //     return View(login);

        // }

        
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        // public  IActionResult Signup(Applicants applicants)
        // {
        //     if (ModelState.IsValid){
        //     try{

        //         // _projectDatabaseContext.applicants.Add(applicants);
        //         // await _projectDatabaseContext.SaveChangesAsync();
        //         // return RedirectToAction("MainIndex" , "Mainpage");



        //     }
        //     catch(Exception){
        //          ModelState.AddModelError("", "Unable to Register.");

        //     }

        //     }


        //     return View(applicants);

        
        // }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}

