using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public class HomeController : Controller
    {
        //Call the function to connect to the database
        private StationeryManagementContext context;
        public HomeController(StationeryManagementContext context) => this.context = context;

        public IActionResult Index(int page = 1)
        {
            int limit = 5; //Number of records want to display
            int role = (int)HttpContext.Session.GetInt32("roleId");
            string department = HttpContext.Session.GetString("departmentId");
            int idAcc = (int)HttpContext.Session.GetInt32("idAccount");

            int month = DateTime.Now.Month;
            ViewBag.month = month;

            int day = DateTime.Now.Day;
            ViewBag.day = day;

            int year = DateTime.Now.Year;
            ViewBag.year = year;

            var listDay = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.DateCreate.Day == day && x.Status == 2);
            int costDay = 0;
            foreach(var items in listDay)
            {
                costDay += (int) (items.IdstationerieNavigation.Price * items.Quantity);
            }

            var listMonth = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.DateCreate.Month == month && x.Status == 2);
            int costMonth = 0;
            foreach (var items in listMonth)
            {
                costMonth += (int)(items.IdstationerieNavigation.Price * items.Quantity);
            }

            var listYear = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.DateCreate.Year == year && x.Status == 2);
            int costYear = 0;
            foreach (var items in listYear)
            {
                costYear += (int)(items.IdstationerieNavigation.Price * items.Quantity);
            }

            int countEmployee = context.Employees.Count();

            var listStationery = (from s in context.Stationeries where s.Status == 1 orderby s.Idstationerie select s).Take(5);
            ViewBag.listStationery = listStationery;

            if (role == 1 || role == 2)
            {
                var listPending = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Status != 2).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                ViewBag.costDay = costDay;
                ViewBag.costMonth = costMonth;
                ViewBag.costYear = costYear;

                ViewBag.countEmployee = countEmployee;
                ViewBag.listMonth = listMonth;

                return View(listPending);
            }
            if(role == 3 && department.Equals("DAD"))
            {
                var listPending = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Status != 2 && x.Status != 1).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                ViewBag.costDay = costDay;
                ViewBag.costMonth = costMonth;
                ViewBag.costYear = costYear;

                ViewBag.countEmployee = countEmployee;
                ViewBag.listMonth = listMonth;

                return View(listPending);
            }
            else
            {
                var listPending = context.RequestStationery.Include(X => X.IdstationerieNavigation).Where(x => x.Status == 1).Where(x => x.Idemployee == idAcc).OrderByDescending(x => x.DateCreate).ToPagedList(page, limit);
                ViewBag.costDay = costDay;
                ViewBag.costMonth = costMonth;
                ViewBag.costYear = costYear;

                ViewBag.countEmployee = countEmployee;
                ViewBag.listMonth = listMonth.Where(x => x.Idemployee == idAcc);

                return View(listPending);
            }
        }

    }
}
