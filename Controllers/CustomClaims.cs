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
    public class CustomClaims : Controller
    {
       
       public  void addAuthentication(User currentUser){


            var userIdentity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Name , currentUser.Email)
            } , CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(userIdentity);
            var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme , principal);



       }
    }
}

