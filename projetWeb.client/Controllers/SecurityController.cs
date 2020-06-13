﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using projetWeb.client.Models;
using projetWeb.client.Security;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projetWeb.client.Controllers
{
    public class SecurityController : Controller
    {
        private readonly UserManager<AppIdentityUser> userManager;
        private readonly RoleManager<AppIdentityRole> roleManager;
        private readonly SignInManager<AppIdentityUser> signinManager;

        public SecurityController(
            UserManager<AppIdentityUser> userManager, 
            RoleManager<AppIdentityRole> roleManager,
            SignInManager<AppIdentityUser> signinManager
            )
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signinManager = signinManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterAsync(Register obj)
        {
            if (ModelState.IsValid)
            {
                if (!await roleManager.RoleExistsAsync("Gestionnaire"))
                {
                    AppIdentityRole role = new AppIdentityRole();
                    role.Name = "Gestionnaire";
                    role.Description = "Can perform CRUD operations.";
                    IdentityResult roleResult = await roleManager.
                    CreateAsync(role);
                }

                AppIdentityUser user = new AppIdentityUser();
                user.LastName = obj.LastName;
                user.FirstName = obj.FirstName;
                user.Email = obj.Email;
                user.PhoneNumber = obj.PhoneNumber;
                user.Professional = obj.Professional;
                user.Gender = obj.Gender;
                user.BirthDate = obj.BirthDate;

                IdentityResult result = await userManager.CreateAsync
                (user, obj.Password);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Manager");
                    return RedirectToAction("SignIn", "Security");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid user details");
                }
            }
            return View(obj);
        }


        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignInAsync(SignIn obj)
        {
            if (ModelState.IsValid)
            {
                var result = await signinManager.PasswordSignInAsync(obj.Email, obj.Password, obj.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("List", "EmployeeManager");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid user details");
                }
            }
            return View(obj);
        }


        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignOutAsync()
        {
            await signinManager.SignOutAsync();
            return RedirectToAction("SignIn", "Security");
        }


        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
