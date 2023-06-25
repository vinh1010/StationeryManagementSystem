using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StationeryManagementSystem.Models;
using X.PagedList;

namespace StationeryManagementSystem.Controllers
{
    [Authorize]
    public class RoleController : Controller
    {
        //Call the function to connect to the database
        private StationeryManagementContext context;
        public RoleController(StationeryManagementContext context) => this.context = context;

        public IActionResult Index(string Search, int page = 1)
        {
            int limit = 5; //Number of records want to display
            //Retrieve 5 records with page number 1
            var list = context.Roles.OrderByDescending(r => r.DateCreate).ToPagedList(page, limit);
            //If the search key exists retrieve 5 records by name and page number is 1
            if (!string.IsNullOrEmpty(Search))
            {
                list = context.Roles.Where(r => r.RoleName.Contains(Search)).OrderByDescending(r => r.DateCreate).ToPagedList(page, limit);
            }
            //Return to view index with list
            return View(list);
        }

        //Create view add new position
        public IActionResult Create()
        {
            return View();
        }

        //After submitting data from form
        [HttpPost]
        public IActionResult Create(Roles role)
        {
            bool check = true; //Create a check validation variable

            //Get record by name
            var checkName = context.Roles.FirstOrDefault(r => r.RoleName == role.RoleName);
            if (checkName != null) //If the record exists
            {
                //Notification
                ViewBag.checkName = "Position name already exists !";
                //Assign the variable check = false
                check = false;
            }

            if (string.IsNullOrEmpty(role.RoleName))
            {
                //Notification
                ViewBag.checkNameNull = "Position name cannot be null !";
                //Assign the variable check = false
                check = false;
            }

            //If check = true 
            if (check)
            {
                role.DateCreate = DateTime.Now;

                //Add new to database
                context.Roles.Add(role);
                context.SaveChanges();
                //Notification
                TempData["success"] = "Add new successful";
                //Return to action index
                return RedirectToAction("Index");
            }
            //If check = false
            else
            {
                //Return view add new position and error message
                return View();
            }
        }

        //Create updated view form
        public IActionResult Edit(int id)
        {
            //Find records by id passed from link tag with data type Departments
            Roles model = context.Roles.FirstOrDefault(r => r.Idrole == id);
            //Return to view edit with model
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Roles role)
        {
            bool check = true; //Create a check validation variable

            //Get record by name and != Idrole
            var checkName = context.Roles.FirstOrDefault(x => x.RoleName == role.RoleName && x.Idrole != role.Idrole);
            if (checkName != null) //If the record exists
            {
                //Notification
                ViewBag.checkName = "Position name already exists";
                //Assign the variable check = false
                check = false;
            }

            if (string.IsNullOrEmpty(role.RoleName))
            {
                //Notification
                ViewBag.checkNameNull = "Position name cannot be null !";
                //Assign the variable check = false
                check = false;
            }

            //If check = true 
            if (check)
            {
                role.DateCreate = DateTime.Now;

                //Update the database
                context.Roles.Update(role);
                context.SaveChanges();
                //Notification
                TempData["success"] = "Edit successful";
                //Return to action index
                return RedirectToAction("Index");
            }
            else
            {
                //Find records by id passed from link tag with data type Departments
                Roles model = context.Roles.FirstOrDefault(r => r.Idrole == role.Idrole);
                //Instantiate object with name model with data type DepartmentsViewModel
                //Return to view edit with model
                return View(model);
            }
        }

        //Create delete method
        public IActionResult Delete(int id)
        {
            //Find employee records by role id
            var checkEmployee = context.Employees.FirstOrDefault(e => e.Idrole == id);
            //If a record exists
            if (checkEmployee != null)
            {
                //Notification
                TempData["eror"] = "Position exists employee cannot delete !";
                //Return to action index
                return RedirectToAction("Index");
            }

            else
            {
                //Find records by id passed from link tag
                var role = context.Roles.FirstOrDefault(r => r.Idrole == id);
                //If the record exists
                if (role != null)
                {
                    //Proceed to delete from the database
                    context.Roles.Remove(role);
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