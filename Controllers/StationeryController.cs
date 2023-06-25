using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StationeryManagementSystem.Models;
using StationeryManagementSystem.Models.ViewModels;
using X.PagedList;

namespace StationeryManagementSystem.Controllers
{
    [Authorize]
    public class StationeryController : Controller
    {
        //Call the function to connect to the database
        private StationeryManagementContext context;
        public StationeryController(StationeryManagementContext context) => this.context = context;

        //Create view list stationery
        public IActionResult Index(string Search, int page = 1)
        {
            int limit = 5; //Number of records want to display
            //Retrieve 5 records with page number 1
            var list = context.Stationeries.OrderByDescending(s => s.DateCreate).ToPagedList(page, limit);
            //If the search key exists retrieve 5 records by name and page number is 1
            if (!string.IsNullOrEmpty(Search))
            {
                list = context.Stationeries.Where(s => s.NameStationerie.Contains(Search)).OrderByDescending(s => s.DateCreate).ToPagedList(page, limit);
            }
            //Return to view index with list
            return View(list);
        }

        //Create view add new stationery
        public IActionResult Create()
        {
            return View();
        }

        //After submitting data from form
        [HttpPost]
        public IActionResult Create(StationeriesViewModel stationery)
        {
            //The case of passing the error cases in form
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files; //Get data from form with file type
                if (files.Count() > 0 && files[0].Length > 0) //Usually non-null data case
                {
                    //Some functions to process image files
                    var file = files[0];
                    var FileName = file.FileName;
                    //Move the image to the created folder called wwwroot\\stationeries
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\stationeries", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        stationery.Image = FileName; //Assign an image name to the Image attribute
                    }

                    //Start a new Stationeries
                    Stationeries s = new Stationeries
                    {
                        //Reassign properties from type StationeriesViewModel
                        Idstationerie = stationery.Idstationerie,
                        NameStationerie = stationery.NameStationerie,
                        UnitOfMeasure = stationery.UnitOfMeasure,
                        Price = stationery.Price,
                        Image = stationery.Image,
                        DateCreate = DateTime.Now,
                        Status = stationery.Status
                    };

                    //Add new to database
                    context.Stationeries.Add(s);
                    context.SaveChanges();
                    //Notification
                    TempData["success"] = "Add new successful";
                    //Return to action index
                    return RedirectToAction("Index");
                }
                //The case of null data
                else
                {
                    //Assign image error message to view bag
                    ViewBag.Image = "Please choose a image";
                    //Return view add new stationery
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
        public IActionResult Edit(int id)
        {
            //Find records by id passed from link tag with data type Stationeries
            Stationeries stationeries = context.Stationeries.FirstOrDefault(s => s.Idstationerie == id);
            //Instantiate object with name model with data type StationeriesViewModel
            StationeriesViewModel model = new StationeriesViewModel
            {
                //Reassign properties from type Stationeries to type StationeriesViewModel
                Idstationerie = stationeries.Idstationerie,
                NameStationerie = stationeries.NameStationerie,
                UnitOfMeasure = stationeries.UnitOfMeasure,
                Image = stationeries.Image,
                Price = stationeries.Price,
                DateCreate = stationeries.DateCreate,
                Status = stationeries.Status
            };
            //Return to view edit with model
            return View(model);
        }

        //After submitting data from form
        [HttpPost]
        public IActionResult Edit(StationeriesViewModel stationery)
        {
            //The case of passing the error cases in form
            if (ModelState.IsValid)
            {
                //Some functions to process image files
                var files = HttpContext.Request.Form.Files;
                if (files.Count() > 0 && files[0].Length > 0)
                {
                    //Some functions to process image files
                    var file = files[0];
                    var FileName = file.FileName;
                    //Move the image to the created folder called wwwroot\\stationeries
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\stationeries", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        stationery.Image = FileName; //Assign an image name to the Image attribute
                    }
                }

                //If you don't update the photo, get the information back from the old photo
                Stationeries s = new Stationeries
                {
                    //Reassign properties from type StationeriesViewModel
                    Idstationerie = stationery.Idstationerie,
                    NameStationerie = stationery.NameStationerie,
                    UnitOfMeasure = stationery.UnitOfMeasure,
                    Price = stationery.Price,
                    Image = stationery.Image,
                    DateCreate = DateTime.Now,
                    Status = stationery.Status
                };

                //Update the database
                context.Stationeries.Update(s);
                context.SaveChanges();
                //Notification
                TempData["success"] = "Edit successful";
                //Return to action index
                return RedirectToAction("Index");
            }
            //The case does not pass the error cases in the form
            else
            {
                //Find the record that needs to be edited and return to the edit form
                Stationeries stationeries = context.Stationeries.FirstOrDefault(s => s.Idstationerie == stationery.Idstationerie);
                StationeriesViewModel model = new StationeriesViewModel
                {
                    Idstationerie = stationeries.Idstationerie,
                    NameStationerie = stationeries.NameStationerie,
                    UnitOfMeasure = stationeries.UnitOfMeasure,
                    Image = stationeries.Image,
                    Price = stationeries.Price,
                    DateCreate = stationeries.DateCreate,
                    Status = stationeries.Status
                };
                //Return to view edit with model
                return View(model);
            }
        }

        //Create delete method
        public IActionResult Delete(int id)
        {
            //Find records by id passed from link tag
            var stationery = context.Stationeries.FirstOrDefault(s => s.Idstationerie == id);
            //If the record exists
            if (stationery != null)
            {
                //Proceed to delete from the database
                context.Stationeries.Remove(stationery);
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