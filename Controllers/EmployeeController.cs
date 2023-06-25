using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StationeryManagementSystem.Models;
using StationeryManagementSystem.Models.ViewModels;
using System.Text.RegularExpressions;
using X.PagedList;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace StationeryManagementSystem.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        //Call the function to connect to the database
        private StationeryManagementContext context;
        public EmployeeController(StationeryManagementContext context) => this.context = context;

        public IActionResult Index(string Search, int page = 1)
        {
            int limit = 5; //Number of records want to display
            //Retrieve 5 records with page number 1
            int role = (int) HttpContext.Session.GetInt32("roleId");
            string department = HttpContext.Session.GetString("departmentId");

            if(role == 1 || role == 2)
            {
                var list = context.Employees.Include(e => e.IddepartmentNavigation).OrderByDescending(e => e.Idemployee).ToPagedList(page, limit);
                //If the search key exists retrieve 5 records by name and page number is 1
                if (!string.IsNullOrEmpty(Search))
                {
                    list = context.Employees.Where(s => s.NameEmployee.Contains(Search)).OrderByDescending(e => e.Idemployee).ToPagedList(page, limit);
                }
                //Return to view index with list
                return View(list);
            }

            if(role == 3)
            {
                var list = context.Employees.Include(e => e.IddepartmentNavigation).Where(e => e.Iddepartment == department).OrderByDescending(e => e.Idemployee).ToPagedList(page, limit);
                //If the search key exists retrieve 5 records by name and page number is 1
                if (!string.IsNullOrEmpty(Search))
                {
                    list = context.Employees.Where(e => e.Iddepartment == department).Where(s => s.NameEmployee.Contains(Search)).OrderByDescending(e => e.Idemployee).ToPagedList(page, limit);
                }
                //Return to view index with list
                return View(list);
            }

            else
            {
                TempData["Eror"] = "Expired version. Please log in again";
                return RedirectToAction("Login", "Account");
            }
        }

        //Create view add new employee
        public IActionResult Create()
        {
            //Get a list of departments
            var listDepartment = context.Departments.Where(d => d.Status == 1).ToList();
            ViewBag.listDepartment = listDepartment;
            //Get the list of positions
            int role = (int)HttpContext.Session.GetInt32("roleId");
            if(role == 2)
            {
                var listRole = context.Roles.Where(r => r.Status == 1).Where(r => r.Idrole != 1).ToList();
                ViewBag.listRole = listRole;
            }
            else
            {
                var listRole = context.Roles.Where(r => r.Status == 1).ToList();
                ViewBag.listRole = listRole;
            }
            
            return View();
        }

        //After submitting data from form
        [HttpPost]
        public IActionResult Create(EmployeeViewModel employee)
        {
            //The case of passing the error cases in form
            if (ModelState.IsValid)
            {
                bool check = true; //Create a check validation variable

                //Get record by emailId
                var checkEmail = context.Employees.FirstOrDefault(e => e.EmailId == employee.EmailId);
                if (checkEmail != null) //If the record exists
                {
                    //Notification
                    ViewBag.checkEmail = "Email id already exists !";
                    //Assign the variable check = false
                    check = false;
                }

                //If check = true 
                if (check)
                {
                    //Start a new employee
                    Employees e = new Employees
                    {
                        NameEmployee = employee.NameEmployee,
                        EmailId = employee.EmailId,
                        Password = employee.Password,
                        Adress = employee.Adress,
                        Sex = employee.Sex,
                        BirthDay = employee.BirthDay,
                        RegistrationNumber = employee.RegistrationNumber,
                        Iddepartment = employee.Iddepartment,
                        Idrole = employee.Idrole,
                        Status = employee.Status
                    };

                    //Add new to database
                    context.Employees   .Add(e);
                    context.SaveChanges();
                    //Notification
                    TempData["success"] = "Add new successful";
                    //Return to action index
                    return RedirectToAction("Index");
                }
                //If check = false
                else
                {
                    //Get a list of departments
                    var listDepartment = context.Departments.Where(d => d.Status == 1).ToList();
                    ViewBag.listDepartment = listDepartment;
                    //Get the list of positions
                    var listRole = context.Roles.Where(r => r.Status == 1).ToList();
                    ViewBag.listRole = listRole;
                    //Return view add new employee and error message
                    return View();
                }
            }
            else
            {
                //Get a list of departments
                var listDepartment = context.Departments.Where(d => d.Status == 1).ToList();
                ViewBag.listDepartment = listDepartment;
                //Get the list of positions
                var listRole = context.Roles.Where(r => r.Status == 1).ToList();
                ViewBag.listRole = listRole;
                //Return view add new employee and error message
                return View();
            }
        }

        //Create updated view form
        public IActionResult Edit(int id)
        {
            int role = (int)HttpContext.Session.GetInt32("roleId");
            if (id == 0 && role != 1)
            {
                //Notification
                TempData["eror"] = "Account does not have enough access rights !";
                //Return to action index
                return RedirectToAction("Index");
            }
            else
            {
                //Find records by id passed from link tag with data type Employees
                Employees employee = context.Employees.FirstOrDefault(e => e.Idemployee == id);
                //Instantiate object with name model with data type EmployeeViewModel
                EmployeeViewModel model = new EmployeeViewModel
                {
                    //Reassign properties from type Departments to type DepartmentsViewModel
                    Idemployee = employee.Idemployee,
                    NameEmployee = employee.NameEmployee,
                    EmailId = employee.EmailId,
                    Password = employee.Password,
                    Adress = employee.Adress,
                    Sex = employee.Sex,
                    BirthDay = employee.BirthDay,
                    RegistrationNumber = employee.RegistrationNumber,
                    Iddepartment = employee.Iddepartment,
                    Idrole = employee.Idrole,
                    Status = employee.Status
                };

                //Get a list of departments
                var listDepartment = context.Departments.Where(d => d.Status == 1).ToList();
                ViewBag.listDepartment = listDepartment;
                //Get the list of positions
                var listRole = context.Roles.Where(r => r.Status == 1).ToList();
                ViewBag.listRole = listRole;
                //Return view add new employee and error message

                //Return to view edit with model
                return View(model);
            }
        }

        [HttpPost]
        public IActionResult Edit(EmployeeViewModel e)
        {
            //The case of passing the error cases in form
            if (ModelState.IsValid)
            {
                bool check = true; //Create a check validation variable

                //Get record by emailId and != Idemployee
                var checkEmail = context.Employees.FirstOrDefault(em => em.EmailId == e.EmailId && em.Idemployee != e.Idemployee);
                if (checkEmail != null) //If the record exists
                {
                    //Notification
                    ViewBag.checkEmail = "Email id already exists !";
                    //Assign the variable check = false
                    check = false;
                }

                //If check = true 
                if (check)
                {
                    Employees employees = new Employees
                    {
                        //Reassign properties from type EmployeeViewModel to type Employees
                        Idemployee = e.Idemployee,
                        NameEmployee = e.NameEmployee,
                        EmailId = e.EmailId,
                        Password = e.Password,
                        Adress = e.Adress,
                        Sex = e.Sex,
                        BirthDay = e.BirthDay,
                        RegistrationNumber = e.RegistrationNumber,
                        Iddepartment = e.Iddepartment,
                        Idrole = e.Idrole,
                        Status = e.Status,

                    };

                    //Update the database
                    context.Employees.Update(employees);
                    context.SaveChanges();
                    //Notification
                    TempData["success"] = "Edit successful";
                    //Return to action index
                    return RedirectToAction("Index");
                }
                else
                {
                    //Find records by id passed from link tag with data type Employees
                    Employees employee = context.Employees.FirstOrDefault(em => em.Idemployee == e.Idemployee);
                    //Instantiate object with name model with data type EmployeeViewModel
                    EmployeeViewModel model = new EmployeeViewModel
                    {
                        //Reassign properties from type Departments to type DepartmentsViewModel
                        Idemployee = employee.Idemployee,
                        NameEmployee = employee.NameEmployee,
                        EmailId = employee.EmailId,
                        Password = employee.Password,
                        Adress = employee.Adress,
                        Sex = employee.Sex,
                        BirthDay = employee.BirthDay,
                        RegistrationNumber = employee.RegistrationNumber,
                        Iddepartment = employee.Iddepartment,
                        Idrole = employee.Idrole,
                        Status = employee.Status
                    };

                    //Get a list of departments
                    var listDepartment = context.Departments.Where(d => d.Status == 1).ToList();
                    ViewBag.listDepartment = listDepartment;
                    //Get the list of positions
                    var listRole = context.Roles.Where(r => r.Status == 1).ToList();
                    ViewBag.listRole = listRole;
                    //Return view add new employee and error message

                    //Return to view edit with model
                    return View(model);
                }
            }
            //The case does not pass the error cases in the form
            else
            {
                //Find records by id passed from link tag with data type Employees
                Employees employee = context.Employees.FirstOrDefault(em => em.Idemployee == e.Idemployee);
                //Instantiate object with name model with data type EmployeeViewModel
                EmployeeViewModel model = new EmployeeViewModel
                {
                    //Reassign properties from type Departments to type DepartmentsViewModel
                    Idemployee = employee.Idemployee,
                    NameEmployee = employee.NameEmployee,
                    EmailId = employee.EmailId,
                    Password = employee.Password,
                    Adress = employee.Adress,
                    Sex = employee.Sex,
                    BirthDay = employee.BirthDay,
                    RegistrationNumber = employee.RegistrationNumber,
                    Iddepartment = employee.Iddepartment,
                    Idrole = employee.Idrole,
                    Status = employee.Status
                };

                //Get a list of departments
                var listDepartment = context.Departments.Where(d => d.Status == 1).ToList();
                ViewBag.listDepartment = listDepartment;
                //Get the list of positions
                var listRole = context.Roles.Where(r => r.Status == 1).ToList();
                ViewBag.listRole = listRole;
                //Return view add new employee and error message

                //Return to view edit with model
                return View(model);
            }
        }

        //Create delete method
        public IActionResult Delete(int id)
        {
            int role = (int)HttpContext.Session.GetInt32("roleId");
            if (id == 0 && role != 1)
            {
                //Notification
                TempData["eror"] = "Account does not have enough access rights !";
                //Return to action index
                return RedirectToAction("Index");
            }
            else
            {
                //Find RequestStationery records by employee id
                var checkRequestStationery = context.RequestStationery.FirstOrDefault(x => x.Idemployee == id);
                //If a record exists
                if (checkRequestStationery != null)
                {
                    //Notification
                    TempData["eror"] = "Employee exists request for stationery cannot be deleted !";
                    //Return to action index
                    return RedirectToAction("Index");
                }

                //Find Feedbacks records by employee id
                var checkFeedbacks = context.Feedbacks.FirstOrDefault(x => x.Idemployee == id);
                //If a record exists
                if (checkFeedbacks != null)
                {
                    //Notification
                    TempData["eror"] = "Please delete employee feedback first !";
                    //Return to action index
                    return RedirectToAction("Index");
                }

                else
                {
                    //Find records by id passed from link tag
                    var employee = context.Employees.FirstOrDefault(e => e.Idemployee == id);
                    //If the record exists
                    if (employee != null)
                    {
                        //Proceed to delete from the database
                        context.Employees.Remove(employee);
                        context.SaveChanges();
                        //Notification
                        TempData["success"] = "Delete successful";
                        //Return to action index
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        //Notification
                        TempData["eror"] = "The record does not exist !";
                        //Return to action index
                        return RedirectToAction("Index");
                    }
                }
            }
        }

        //Create view detail
        public IActionResult Detail(int id)
        {
            int role = (int)HttpContext.Session.GetInt32("roleId");
            if (id == 0 && role != 1)
            {
                //Notification
                TempData["eror"] = "Account does not have enough access rights !";
                //Return to action index
                return RedirectToAction("Index");
            }
            else
            {
                //Find records by id passed from link tag with data type Employees
                Employees employee = context.Employees.Include(e => e.IddepartmentNavigation).Include(e => e.IdroleNavigation).FirstOrDefault(e => e.Idemployee == id);

                //Return to view edit with model
                return View(employee);
            }
        }

        //Create view Change Password
        public IActionResult ChangePassword(int id)
        {
            //Find records by id passed from link tag with data type Employees
            Employees employee = context.Employees.FirstOrDefault(em => em.Idemployee == id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult ChangePassword(Employees employee, string NewPassword)
        {
            bool check = true; //Create a check validation variable

            if (employee.Password.Equals(NewPassword))
            {
                ViewBag.ErrorPass = "The new password must be different from the current password !";
                check = false;
            }

            const string pattern = "^.*(?=.{8,})(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            if (!regex.IsMatch(NewPassword))
            {
                ViewBag.ErrorPass = "Wrong password format. At least one lower case letter. At least one upper case letter. At least special character. At least one number. At least 8 characters length !";
                check = false;
            }

            if (string.IsNullOrEmpty(NewPassword))
            {
                ViewBag.ErrorPass = "New password cannot be null !";
                check = false;
            }

            if (check)
            {
                Employees employees = context.Employees.FirstOrDefault(em => em.Idemployee == employee.Idemployee);
                employees.Password = NewPassword;
                //Update the database
                context.Employees.Update(employees);
                context.SaveChanges();
                //Notification
                TempData["success"] = "Password update successful";
                //Return to action index
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}