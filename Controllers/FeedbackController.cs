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
    public class FeedbackController : Controller
    {
        //Call the function to connect to the database
        private StationeryManagementContext context;
        public FeedbackController(StationeryManagementContext context) => this.context = context;

        public IActionResult Index(int Search, int page = 1)
        {
            int limit = 5; //Number of records want to display
            //Retrieve 5 records with page number 1
            var list = context.Feedbacks.OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
            //If the search key exists retrieve 5 records by name and page number is 1
            if (Search != 0)
            {
                list = context.Feedbacks.Where(x => x.Idemployee == Search).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
            }
            //Return to view index with list
            return View(list);
        }

        //Create view send feedback
        public IActionResult Create()
        {
            return View();
        }

        //After submitting data from form
        [HttpPost]
        public IActionResult Create(Feedbacks feedback)
        {
            bool check = true; //Create a check validation variable
           
            //Check content null
            if (string.IsNullOrEmpty(feedback.Content))
            {
                //Notification
                ViewBag.Content = "Content cannot be empty !";
                //Assign the variable check = false
                check = false;
            }

            //If check = true 
            if (check)
            {
                feedback.DateCreate = DateTime.Now;

                //Add new to database
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
                //Notification
                TempData["success"] = "Send feedback successfully";
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

        //Create view detail
        public IActionResult Detail(int id)
        {
            //Find records by id passed from link tag with data type Feedbacks
            Feedbacks feedbacks = context.Feedbacks.FirstOrDefault(x => x.Idfeedback == id);
            //Return to view edit with model
            return View(feedbacks);
        }

        //Create delete method
        public IActionResult Delete(int id)
        {
            //Find records by id passed from link tag
            var feedback = context.Feedbacks.FirstOrDefault(x => x.Idfeedback == id);
            //If the record exists
            if (feedback != null)
            {
                //Proceed to delete from the database
                context.Feedbacks.Remove(feedback);
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