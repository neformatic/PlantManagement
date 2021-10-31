using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using PlantManagment.Web.Models;
using PlantManagment.BusinessLogic.Services;
using System.Collections.Generic;
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
            var positionsList = _headOfDepartmentServices.ShowPositionInfo();
            List<string> positionNameList = new List<string>();
            foreach (var item in positionsList)
            {
                positionNameList.Add(item.PositionName);          
            }
            return View(positionNameList);
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
            return RedirectToAction("Employee", "account");
        }
        public IActionResult Employee()
        {
            return View();
        }

        public IActionResult HeadOfDepartment()
        {
            return View();
        }
    }

}
