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

        /*[HttpGet]
        public IActionResult SortRollerCoasters(string sortOrder)
        {
            var data = processor.LoadRollerCoasters();
            var coasters = from r in data select r;
            switch(sortOrder)
            {
                case "speed_asc":
                    coasters = coasters.OrderBy(r => r.Speed);
                    break;
                case "length_desc":
                    coasters = coasters.OrderByDescending(r => r.Length);
                    break;
                case "height_desc":
                    coasters = coasters.OrderByDescending(r => r.Height);
                    break;
            }
            return View(coasters.ToList());
        }*/
    }
}
