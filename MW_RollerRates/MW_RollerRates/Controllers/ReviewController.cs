using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelLayer;
using DataLayer.DTProcessors;
using MW_RollerRates.Models;

namespace MW_RollerRates.Controllers
{
    public class ReviewController : Controller
    {
        ReviewProcessor processor = new ReviewProcessor();
        RollerCoasterProcessor coasterProcessor =  new RollerCoasterProcessor();
        UserProcessor userProcessor = new UserProcessor();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PlaceReview(PlaceReviewModel review , string rollerName , string userName)
        {
            if (ModelState.IsValid)
            {
                var userData = userProcessor.GetUserByUserName(userName);
                var rollerData = coasterProcessor.GetRollerCoasterByName(rollerName);
                processor.PlaceReview(
                    review.Description,
                    review.Rating,
                    review.User_ID = userData.ID,
                    review.Rollercoaster_ID = rollerData.ID
                    );
                return RedirectToAction("ViewRollercoasters", "Rollercoaster");
            }
            return View();
        }
    }
}
