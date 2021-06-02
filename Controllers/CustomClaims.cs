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
    public class CustomClaims : Controller
    {
       
       public  void addAuthentication(String currentUser){


            var userIdentity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Name , currentUser)
            } , CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(userIdentity);
            var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme , principal);



       }

     public void Alert(NotificationType notificationType , string AlertMessage , string title)
    {
        // var msg = "<script language='javascript'>swal({title: 'MIS',text: 'Case Created your Case Number is "+id+"', icon: 'warning',buttons: true,dangerMode: true})" + "</script>";

        var msg = "";
        switch(notificationType){
                case NotificationType.success:
                    msg = $"<script language='javascript'>swal('{title}','{AlertMessage}', 'success');" + "</script>";
                    TempData["notification"] = msg;
                    break;
                default :
                    Console.Write("none");
                    break;


        }
        // var msg = "<script language='javascript'>swal('Logged In!','You Have Successfully Logged In!', 'warning');" + "</script>";

        
        TempData["notification"] = msg;
    }

    }
}

