using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlantManagment.BusinessLogic.Services;
using PlantManagment.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlantManagment.Web.Controllers
{
    [Authorize(Roles = "Manager")]
    public class ManagerController : Controller
    {
        private HeadOfDepartmentServices _headOfDepartmentServices;
        private EmployeeService _employeeService;
        public ManagerController(HeadOfDepartmentServices headOfDepartmentServices, EmployeeService employeeService)
        {
            _headOfDepartmentServices = headOfDepartmentServices;
            _employeeService = employeeService;
        }
        [HttpGet]
        public IActionResult ManagerMenu()
        {
            var employeeList = _headOfDepartmentServices.ShowEmployeeList();
            List<ManagerViewModel> employees = new List<ManagerViewModel>();
            foreach (var item in employeeList)
            {
                ManagerViewModel model = new ManagerViewModel()
                {
                    Id = item.Id,
                    LastName = item.LastName,
                    FirstName = item.FirstName,
                    MiddleName = item.MiddleName,
                    Position = item.Position
                };
                employees.Add(model);
            }
;            return View(employees);
        }

        [HttpPost]
        public IActionResult ManagerMenu(int employeeId)
        {
            _headOfDepartmentServices.ShowDeleteEmployee(employeeId);
            return RedirectToAction("ManagerMenu");
        }

        public async Task<IActionResult>Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
     
    }
}
