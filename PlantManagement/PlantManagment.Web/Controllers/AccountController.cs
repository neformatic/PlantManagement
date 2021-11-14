using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PlantManagment.BusinessLogic.Services;
using PlantManagment.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PlantManagment.Web.Controllers
{
    public class AccountController : Controller
    {
        private string role = string.Empty;
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
        public IActionResult Registration(RegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                var isUser = _accountServices.IsUser(model.Login, model.Password);
                if (!isUser)
                {
                    _accountServices.AddUser(model.Login, model.Password, model.Position, model.LastName, model.FirstName, model.MiddleName);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("Login", "Login is taken");
            }
            return RedirectToAction("Registration");
        }

        [HttpGet]
        public IActionResult Authorization()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Authorization(AccountViewModel model)
        {
            if (ModelState.IsValid)
            {
                var isUser = _accountServices.IsUser(model.Login, model.Password);
                if (!isUser)
                {
                    ModelState.AddModelError("Password", "Неверный логин или пароль");
                    return View(model);
                }

                var userId = _accountServices.GetUserId(model.Login);
                role = _accountServices.GetRole(userId);
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, model.Login),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType, role)
                };
                
                ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
                
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
            }
            switch (role)
            {
                case "Admin":
                    return RedirectToAction("AdminMenu", "HeadOfDepartment");
                case "Manager":
                    return RedirectToAction("ManagerMenu", "Manager"); 
                case "Default user":
                    return RedirectToAction("TasksMenu", "Employee");
                default:
                    return RedirectToAction("Index", "Home");
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
