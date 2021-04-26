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
    }
}
