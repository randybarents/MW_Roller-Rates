using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.DTProcessors;
using MW_RollerRates.Models;

namespace MW_RollerRates.Controllers
{
    public class UserController : Controller
    {
        UserProcessor Processor = new UserProcessor();

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateUser(UserCreateViewModel user)
        {
            if (ModelState.IsValid)
            {
                Processor.CreateUser(
                    user.Email,
                    user.Password,
                    user.DisplayName,
                    user.Description
                    );
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
