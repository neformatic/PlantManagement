using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using PlantManagment.BusinessLogic.Services;
using PlantManagment.DataAccessLayer.Models;
using PlantManagment.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PlantManagment.Web.Controllers
{
    public class AccountController : Controller
    {
        private HeadOfDepartmentServices _headOfDepartmentServices;
        private AccountServices _accountServices;
        public AccountController(AccountServices accountServices, HeadOfDepartmentServices headOfDepartmentServices)
        {
            _accountServices = accountServices;
            _headOfDepartmentServices = headOfDepartmentServices;
        }
        [HttpGet]
        public IActionResult Registration()
        {
            _headOfDepartmentServices.ShowPositionInfo(); // добавить в выпадающий список
            return View();
        }
        [HttpPost]
        public IActionResult Registration(AccountViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Password.Length > 5)
                {
                    _accountServices.UserRegistration(model.Login, model.Password);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("Password", "Password is short");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Authorization()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Authorization(AccountViewModel model)
        {
            if (ModelState.IsValid)
            {
                var isUser = _accountServices.IsUser(model.Login, model.Password);
                if (!isUser)
                {
                    ModelState.AddModelError("Password", "Неверный логин или пароль");
                    return View(model);
                }
                var claims = new List<Claim>
                {
                new Claim(ClaimsIdentity.DefaultNameClaimType, model.Login)
                };

                ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
            }
            return RedirectToAction("index", "home");
        }
    }

}
