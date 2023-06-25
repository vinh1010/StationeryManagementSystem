using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StationeryManagementSystem.Models;

namespace StationeryManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        //Call the function to connect to the database
        private StationeryManagementContext context;
        public AccountController(StationeryManagementContext context) => this.context = context;

        //Create View Login
        public IActionResult Login()
        {
            return View();
        }

        //After submitting data from form
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            //Check if the email or password is empty
            if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))
            {
                //Error message
                TempData["Eror"] = "Please enter email and password!";
                //Back to login form
                return RedirectToAction("Login", "Account");
            }
            //if email or password is not blank. Check if the data exists in the database
            else
            {
                //Find records by email and password in the database
                var data = context.Employees.Include(e => e.IddepartmentNavigation).FirstOrDefault(e => e.EmailId == email && e.Password == password);
                if (data != null) //If the record exists
                {
                    var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, email) }, "StationeryManagementSecurityScheme");
                    var principal = new ClaimsPrincipal(identity);
                    var login = HttpContext.SignInAsync("StationeryManagementSecurityScheme", principal);
                    HttpContext.Session.SetInt32("idAccount", data.Idemployee);
                    HttpContext.Session.SetString("userName", data.NameEmployee);
                    HttpContext.Session.SetString("departmentName", data.IddepartmentNavigation.NameDepartment);
                    HttpContext.Session.SetString("departmentId", data.Iddepartment);
                    HttpContext.Session.SetInt32("roleId",(int) data.Idrole);

                    //Navigate to the homepage
                    TempData["LoginSuccess"] = "Logged in successfully";
                    return Redirect("/Home/Index");
                }
                else //If no record exists
                {
                    //Error message
                    TempData["Eror"] = "Login False!";
                    //Back to login form
                    return RedirectToAction("Login", "Account");
                }
            }
        }

        public IActionResult Logout()
        {
            var logout = HttpContext.SignOutAsync("StationeryManagementSecurityScheme");
            HttpContext.Session.Remove("idAccount");
            HttpContext.Session.Remove("userName");
            HttpContext.Session.Remove("departmentName");
            HttpContext.Session.Remove("departmentId");
            HttpContext.Session.Remove("roleId");
            return RedirectToAction("Login", "Account");
        }
    }
}