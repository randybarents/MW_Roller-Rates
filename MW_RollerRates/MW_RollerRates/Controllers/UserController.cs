using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.DTProcessors;
using MW_RollerRates.Models;
using ModelLayer;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

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
        public IActionResult CreateUser(UserCreateModel user)
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

        [HttpGet]
        public IActionResult LoginUser()
        {
            if (@User.Identity.IsAuthenticated)
            {
                return RedirectToAction("ViewRollerCoasters", "RollerCoaster");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginUser(LoginUserViewModel login)
        {
            if (ModelState.IsValid)
            {
                UserDTO userData = Processor.GetUserByEmail(login.Email);
                if (userData != null)
                {
                    if (DataLayer.PasswordHashing.ValidateUser(login.Password, userData.Salt, userData.PasswordHash))
                    {
                        var userIdentity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                        userIdentity.AddClaim(new Claim(ClaimTypes.Name, userData.DisplayName));
                        userIdentity.AddClaim(new Claim(ClaimTypes.Email, userData.Email));

                        var userPrincipal = new ClaimsPrincipal(userIdentity);

                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal);
                        return RedirectToAction("ViewRollerCoasters", "RollerCoaster");
                    }
                }
            }
            return View();
        }

        [Authorize]
        public IActionResult LogoutUser()
        {
            if (@User.Identity.IsAuthenticated)
            {
                HttpContext.SignOutAsync();
            }
            return RedirectToAction("LoginUser", "User");
        }

        [HttpGet]
        public IActionResult ViewProfile()
        {
            var userData = Processor.GetUserByUserName(User.Identity.Name);
            UserProfileViewModel userViewModel = new UserProfileViewModel
            {
                Id = userData.ID,
                Email = userData.Email,
                DisplayName = userData.DisplayName,
                Description = userData.Description
            };
            return View(userViewModel);
        }
    }
}
