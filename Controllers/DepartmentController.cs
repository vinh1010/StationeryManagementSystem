using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StationeryManagementSystem.Models;
using StationeryManagementSystem.Models.ViewModels;
using X.PagedList;

namespace StationeryManagementSystem.Controllers
{
    [Authorize]
    public class DepartmentController : Controller
    {
        //Call the function to connect to the database
        private StationeryManagementContext context;
        public DepartmentController(StationeryManagementContext context) => this.context = context;

        public IActionResult Index(string Search, int page = 1)
        {
            int limit = 5; //Number of records want to display
            //Retrieve 5 records with page number 1
            var list = context.Departments.OrderByDescending(d => d.DateCreate).ToPagedList(page, limit);
            //If the search key exists retrieve 5 records by name and page number is 1
            if (!string.IsNullOrEmpty(Search))
            {
                list = context.Departments.Where(s => s.NameDepartment.Contains(Search)).OrderByDescending(d => d.DateCreate).ToPagedList(page, limit);
            }
            //Return to view index with list
            return View(list);
        }

        //Create view add new department
        public IActionResult Create()
        {
            return View();
        }

        //After submitting data from form
        [HttpPost]
        public IActionResult Create(DepartmentsViewModel department)
        {
            //The case of passing the error cases in form
            if (ModelState.IsValid)
            {
                bool check = true; //Create a check validation variable

                //Get record by id
                var checkId = context.Departments.FirstOrDefault(dp => dp.Iddepartment == department.Iddepartment);
                //If the record exists
                if (checkId != null)
                {
                    //Notification
                    ViewBag.checkId = "Department id already exists !";
                    //Assign the variable check = false
                    check = false;
                }

                //Get record by name
                var checkName = context.Departments.FirstOrDefault(dp => dp.NameDepartment == department.NameDepartment);
                if (checkName != null) //If the record exists
                {
                    //Notification
                    ViewBag.checkName = "Department name already exists !";
                    //Assign the variable check = false
                    check = false;
                }

                //If check = true 
                if (check)
                {
                    //Start a new Departments
                    Departments d = new Departments
                    {
                        //Reassign properties from type DepartmentsViewModel
                        Iddepartment = department.Iddepartment,
                        NameDepartment = department.NameDepartment,
                        DateCreate = DateTime.Now,
                        Status = department.Status
                    };

                    //Add new to database
                    context.Departments.Add(d);
                    context.SaveChanges();
                    //Notification
                    TempData["success"] = "Add new successful";
                    //Return to action index
                    return RedirectToAction("Index");
                }
                //If check = false
                else
                {
                    //Return view add new stationery and error message
                    return View();
                }
                
            }
            //The case does not pass the error cases in the form
            else
            {
                //Return view add new stationery and error message
                return View();
            }
        }

        //Create updated view form
        public IActionResult Edit(string id)
        {
            //Find records by id passed from link tag with data type Departments
            Departments departments = context.Departments.FirstOrDefault(d => d.Iddepartment == id);
            //Instantiate object with name model with data type DepartmentsViewModel
            DepartmentsViewModel model = new DepartmentsViewModel
            {
                //Reassign properties from type Departments to type DepartmentsViewModel
                Iddepartment = departments.Iddepartment,
                NameDepartment = departments.NameDepartment,
                DateCreate = departments.DateCreate,
                Status = departments.Status
            };
            //Return to view edit with model
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(DepartmentsViewModel department)
        {
            //The case of passing the error cases in form
            if (ModelState.IsValid)
            {
                bool check = true; //Create a check validation variable

                //Get record by name and != Iddepartment
                var checkName = context.Departments.FirstOrDefault(dp => dp.NameDepartment == department.NameDepartment && dp.Iddepartment.Equals(department.Iddepartment) == false);
                if (checkName != null) //If the record exists
                {
                    //Notification
                    ViewBag.checkName = "Department name already exists";
                    //Assign the variable check = false
                    check = false;
                }

                //If check = true 
                if (check)
                {
                    Departments d = new Departments
                    {
                        //Reassign properties from type DepartmentsViewModel
                        Iddepartment = department.Iddepartment,
                        NameDepartment = department.NameDepartment,
                        DateCreate = DateTime.Now,
                        Status = department.Status
                    };

                    //Update the database
                    context.Departments.Update(d);
                    context.SaveChanges();
                    //Notification
                    TempData["success"] = "Edit successful";
                    //Return to action index
                    return RedirectToAction("Index");
                }
                else
                {
                    //Find records by id passed from link tag with data type Departments
                    Departments departments = context.Departments.FirstOrDefault(d => d.Iddepartment == department.Iddepartment);
                    //Instantiate object with name model with data type DepartmentsViewModel
                    DepartmentsViewModel model = new DepartmentsViewModel
                    {
                        //Reassign properties from type Departments to type DepartmentsViewModel
                        Iddepartment = departments.Iddepartment,
                        NameDepartment = departments.NameDepartment,
                        DateCreate = departments.DateCreate,
                        Status = departments.Status
                    };
                    //Return to view edit with model
                    return View(model);
                }   
            }
            //The case does not pass the error cases in the form
            else
            {
                //Find records by id passed from link tag with data type Departments
                Departments departments = context.Departments.FirstOrDefault(d => d.Iddepartment == department.Iddepartment);
                //Instantiate object with name model with data type DepartmentsViewModel
                DepartmentsViewModel model = new DepartmentsViewModel
                {
                    //Reassign properties from type Departments to type DepartmentsViewModel
                    Iddepartment = departments.Iddepartment,
                    NameDepartment = departments.NameDepartment,
                    DateCreate = departments.DateCreate,
                    Status = departments.Status
                };
                //Return to view edit with model
                return View(model);
            }
        }

        //Create delete method
        public IActionResult Delete(string id)
        {
            //Find employee records by department id
            var checkEmployee = context.Employees.FirstOrDefault(e => e.Iddepartment == id);
            //If a record exists
            if (checkEmployee != null)
            {
                //Notification
                TempData["eror"] = "Department exists employee cannot delete !";
                //Return to action index
                return RedirectToAction("Index");
            }

            else
            {
                //Find records by id passed from link tag
                var department = context.Departments.FirstOrDefault(d => d.Iddepartment == id);
                //If the record exists
                if (department != null)
                {
                    //Proceed to delete from the database
                    context.Departments.Remove(department);
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
}