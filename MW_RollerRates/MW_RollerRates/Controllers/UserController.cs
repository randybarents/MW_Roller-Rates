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
                return RedirectToAction("Index", "Home");
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
                        var userClaims = new List<Claim>()
                        {
                            new Claim(ClaimTypes.Name , userData.DisplayName),
                            new Claim(ClaimTypes.Email , userData.Email)
                        };

                        var userIdentity = new ClaimsIdentity(userClaims , "User Identity");
                        var userPrincipal = new ClaimsPrincipal(new[] { userIdentity });


                        await HttpContext.SignInAsync(userPrincipal);
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
    }
}
