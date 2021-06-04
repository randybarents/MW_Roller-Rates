using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.DTProcessors;
using MW_RollerRates.Models;
using Microsoft.AspNetCore.Mvc;

namespace MW_RollerRates.Controllers
{
    public class RollerCoasterController : Controller
    {
        RollerCoasterProcessor processor = new RollerCoasterProcessor();
        UserRollerCoasterProcessor userRollerprocessor = new UserRollerCoasterProcessor();
        UserProcessor userProcessor = new UserProcessor();

        [HttpGet]
        public IActionResult Index(string sortOrder)
        {
            ViewBag.NameSortParm = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.SpeedSortParm = sortOrder == "Speed" ? "speed_desc" : "Speed";
            ViewBag.LengthSortParm = sortOrder == "Length" ? "length_desc" : "Length";
            ViewBag.HeightSortParm = sortOrder == "Height" ? "height_desc" : "Height";
            var rollercoasters = processor.LoadRollerCoasters();
            var rollercoasterstosort = from s in rollercoasters
                                      select s;
            switch (sortOrder)
            {
                case "name_asc":
                    rollercoasterstosort = rollercoasterstosort.OrderBy(s => s.Name);
                    break;
                case "name_desc":
                    rollercoasterstosort = rollercoasterstosort.OrderByDescending(s => s.Name);
                    break;
                case "speed_asc":
                    rollercoasterstosort = rollercoasterstosort.OrderBy(s => s.Speed);
                    break;
                case "speed_desc":
                    rollercoasterstosort = rollercoasterstosort.OrderByDescending(s => s.Speed);
                    break;
                case "length_asc":
                    rollercoasterstosort = rollercoasterstosort.OrderBy(s => s.Length);
                    break;
                case "length_desc":
                    rollercoasterstosort = rollercoasterstosort.OrderByDescending(s => s.Length);
                    break;
                case "height_asc":
                    rollercoasterstosort = rollercoasterstosort.OrderBy(s => s.Height);
                    break;
                case "height_desc":
                    rollercoasterstosort = rollercoasterstosort.OrderByDescending(s => s.Height);
                    break;
            }
            return View(rollercoasterstosort.ToList());
        }


        [HttpGet]
        public IActionResult ViewRollerCoasters()
        {
            var data = processor.LoadRollerCoasters();
            List<ViewRollerCoasterModel> items = new List<ViewRollerCoasterModel>();
            foreach (var row in data)
            {
                items.Add(new ViewRollerCoasterModel
                {
                    Name = row.Name,
                    Speed = row.Speed,
                    Length = row.Length,
                    Height = row.Height
                });
            }
            return View(items);
        }

        public IActionResult CheckinRollercoaster(string rollerName)
        {
            var userName = User.Identity.Name;
            var userData = userProcessor.GetUserByUserName(userName);
            var rollerData = processor.GetRollerCoasterByName(rollerName);
            userRollerprocessor.CheckinRollerCoaster(userData.ID, rollerData.ID);
            return RedirectToAction("ViewProfile" , "User");
        }
    }
}
