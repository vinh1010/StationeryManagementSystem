using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StationeryManagementSystem.Models;
using X.PagedList;

namespace StationeryManagementSystem.Controllers
{
    [Authorize]
    public class RequestStationeryController : Controller
    {
        //Call the function to connect to the database
        private StationeryManagementContext context;
        public RequestStationeryController(StationeryManagementContext context) => this.context = context;

        public IActionResult Index(int Search, string from, string to, int page = 1)
        {
            int limit = 5; //Number of records want to display
            int role = (int)HttpContext.Session.GetInt32("roleId");
            string department = HttpContext.Session.GetString("departmentId");
            int idAcc = (int)HttpContext.Session.GetInt32("idAccount");

            if (!string.IsNullOrEmpty(from) && !string.IsNullOrEmpty(to))
            {
                DateTime? fromDate = DateTime.Parse(from);
                DateTime? toDate = DateTime.Parse(to);

                if (role == 1 || role == 2)
                {
                    //Retrieve 5 records with page number 1
                    var list = context.RequestStationery.Include(X => X.IdstationerieNavigation).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                    if (fromDate != null && toDate != null)
                    {
                        list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.DateCreate >= fromDate && x.DateCreate <= toDate).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                    }
                    //If the search key exists retrieve 5 records by name and page number is 1
                    if (Search != 0)
                    {
                        list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Idemployee == Search).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                        if (fromDate != null && toDate != null)
                        {
                            list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Idemployee == Search && x.DateCreate >= fromDate && x.DateCreate <= toDate).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                        }
                    }
                    //Return to view index with list
                    return View(list);
                }

                if (role == 3 && department.Equals("DAD"))
                {
                    //Retrieve 5 records with page number 1
                    var list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Status != 2).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                    if (fromDate != null && toDate != null)
                    {
                        list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Status != 2 && x.DateCreate >= fromDate && x.DateCreate <= toDate).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                    }
                    //If the search key exists retrieve 5 records by name and page number is 1
                    if (Search != 0)
                    {
                        list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Status != 2).Where(x => x.Idemployee == Search).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                        if (fromDate != null && toDate != null)
                        {
                            list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Status != 2 && x.DateCreate >= fromDate && x.DateCreate <= toDate).Where(x => x.Idemployee == Search).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                        }
                    }
                    //Return to view index with list
                    return View(list);
                }

                if (role == 4)
                {
                    //Retrieve 5 records with page number 1
                    var list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Idemployee == idAcc).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                    if (fromDate != null && toDate != null)
                    {
                        list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Idemployee == idAcc && x.DateCreate >= fromDate && x.DateCreate <= toDate).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                    }
                    //If the search key exists retrieve 5 records by name and page number is 1
                    if (Search != 0)
                    {
                        list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Idemployee == idAcc).Where(x => x.Idemployee == Search).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                        if (fromDate != null && toDate != null)
                        {
                            list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Idemployee == idAcc).Where(x => x.Idemployee == Search && x.DateCreate >= fromDate && x.DateCreate <= toDate).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                        }
                    }
                    //Return to view index with list
                    return View(list);
                }

                else
                {
                    //Retrieve 5 records with page number 1
                    var list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Idemployee == idAcc).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                    if (fromDate != null && toDate != null)
                    {
                        list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Idemployee == idAcc && x.DateCreate >= fromDate && x.DateCreate <= toDate).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                    }
                    //If the search key exists retrieve 5 records by name and page number is 1
                    if (Search != 0)
                    {
                        list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Idemployee == idAcc).Where(x => x.Idemployee == Search).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                        if (fromDate != null && toDate != null)
                        {
                            list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Idemployee == idAcc).Where(x => x.Idemployee == Search && x.DateCreate >= fromDate && x.DateCreate <= toDate).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                        }
                    }
                    //Return to view index with list
                    return View(list);
                }
            }
            else
            {
                if (role == 1 || role == 2)
                {
                    //Retrieve 5 records with page number 1
                    var list = context.RequestStationery.Include(X => X.IdstationerieNavigation).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                    //If the search key exists retrieve 5 records by name and page number is 1
                    if (Search != 0)
                    {
                        list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Idemployee == Search).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                    }
                    //Return to view index with list
                    return View(list);
                }

                if (role == 3 && department.Equals("DAD"))
                {
                    //Retrieve 5 records with page number 1
                    var list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Status != 2).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                    //If the search key exists retrieve 5 records by name and page number is 1
                    if (Search != 0)
                    {
                        list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Status != 2).Where(x => x.Idemployee == Search).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                    }
                    //Return to view index with list
                    return View(list);
                }

                if (role == 4)
                {
                    //Retrieve 5 records with page number 1
                    var list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Idemployee == idAcc).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                    //If the search key exists retrieve 5 records by name and page number is 1
                    if (Search != 0)
                    {
                        list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Idemployee == idAcc).Where(x => x.Idemployee == Search).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                    }
                    //Return to view index with list
                    return View(list);
                }

                else
                {
                    //Retrieve 5 records with page number 1
                    var list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Idemployee == idAcc).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                    //If the search key exists retrieve 5 records by name and page number is 1
                    if (Search != 0)
                    {
                        list = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Idemployee == idAcc).Where(x => x.Idemployee == Search).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                    }
                    //Return to view index with list
                    return View(list);
                }
            }
        }

        public IActionResult Create()
        {
            var listStationery = context.Stationeries.Where(s => s.Status == 1).ToList();
            ViewBag.listStationery = listStationery;
            return View();
        }

        [HttpPost]
        public IActionResult Create(RequestStationery requestStationery)
        {
            bool check = true;

            if(requestStationery.Idstationerie == null)
            {
                ViewBag.Idstationerie = "Please select stationery !";
                check = false;
            }

            if(requestStationery.Quantity <= 0)
            {
                ViewBag.Quantity = "Enter a number greater than 0 !";
                check = false;
            }

            if (check)
            {
                requestStationery.DateCreate = DateTime.Now;
                requestStationery.Status = 0;

                //Add new to database
                context.RequestStationery.Add(requestStationery);
                context.SaveChanges();
                //Notification
                TempData["success"] = "The request has been sent successfully !";
                //Return to action index
                return RedirectToAction("Index");
            }
            else
            {
                var listStationery = context.Stationeries.Where(s => s.Status == 1).ToList();
                ViewBag.listStationery = listStationery;
                return View();
            }
        }

        public IActionResult Edit(int id)
        {
            var rs = context.RequestStationery.Include(X => X.IdemployeeNavigation).Include(X => X.IdstationerieNavigation).FirstOrDefault(x => x.IdrequestStationery == id);
            return View(rs);
        }

        public IActionResult Browse(int id)
        {
            RequestStationery rs = context.RequestStationery.FirstOrDefault(x => x.IdrequestStationery == id);
            int role = (int) HttpContext.Session.GetInt32("roleId");

            if(role == 1 || role == 2)
            {
                if(rs.Status == 2)
                {
                    TempData["eror"] = "Unable to update status !";
                    //Return to action index
                    return RedirectToAction("Index");
                }
                else
                {
                    rs.Status = 2;
                    context.RequestStationery.Update(rs);
                    context.SaveChanges();
                    //Notification
                    TempData["success"] = "Browse request successfully !";
                    //Return to action index
                    return RedirectToAction("Index");
                }
            }

            if(role == 3)
            {
                rs.Status = 1;
                context.RequestStationery.Update(rs);
                context.SaveChanges();
                //Notification
                TempData["success"] = "Browse request successfully !";
                //Return to action index
                return RedirectToAction("Index");
            }

            else
            {
                TempData["eror"] = "Please log in again !";
                //Return to action index
                return RedirectToAction("Index");
            }
        }

        public IActionResult Cancel(int id)
        {
            RequestStationery rs = context.RequestStationery.FirstOrDefault(x => x.IdrequestStationery == id);
            rs.Status = 3;
            context.RequestStationery.Update(rs);
            context.SaveChanges();
            //Notification
            TempData["success"] = "Cancel request successfully !";
            //Return to action index
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            RequestStationery rs = context.RequestStationery.FirstOrDefault(x => x.IdrequestStationery == id);

            if(rs.Status == 3)
            {
                //Proceed to delete from the database
                context.RequestStationery.Remove(rs);
                context.SaveChanges();
                //Notification
                TempData["success"] = "Delete successful";
                //Return to action index
                return RedirectToAction("Index");
            }
            else
            {
                //Notification
                TempData["eror"] = "Please cancel the request before deleting !";
                //Return to action index
                return RedirectToAction("Index");
            }
        }
    }
}