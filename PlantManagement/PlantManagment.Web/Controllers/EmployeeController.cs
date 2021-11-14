using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlantManagment.BusinessLogic.Services;
using PlantManagment.Web.Models;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PlantManagment.Web.Controllers
{
    [Authorize(Roles = "Default user")]
    public class EmployeeController : Controller
    {
        private HeadOfDepartmentServices _headOfDepartmentServices;
        private AccountServices _accountServices;
        private EmployeeTaskServices _taskServices;
        private UserInfoServices _infoServices;
        private EmployeeService _employeeService;

        public EmployeeController(AccountServices accountServices, HeadOfDepartmentServices headOfDepartmentServices, EmployeeTaskServices taskServices, UserInfoServices infoServices, EmployeeService employeeService)
        {
            _accountServices = accountServices;
            _headOfDepartmentServices = headOfDepartmentServices;
            _taskServices = taskServices;
            _infoServices = infoServices;
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult TasksMenu()
        {
            var userLogin = User.FindFirst(ClaimTypes.Name).Value;
            var userId = _accountServices.GetUserId(userLogin);
            var empId = _employeeService.GetEmployeId(userId);
            var userInfo = _infoServices.GetUserInfo(empId);
            List<EmployeeViewModel> employeeTasks = new List<EmployeeViewModel>();
            foreach (var item in userInfo)
            {
                EmployeeViewModel model = new EmployeeViewModel()
                {
                    Id = item.Id,
                    Project = item.Project,
                    Task = item.Task,
                    TaskStatus = item.TaskStatus
                };
                employeeTasks.Add(model);
            }
            return View(employeeTasks);
        }

        [HttpPost]
        public IActionResult TasksMenu(int newTaskStatus, int taskId)
        {
            if (newTaskStatus != default & taskId != default)
            {
                _infoServices.ChangeStatus(taskId, newTaskStatus);
            }
            return RedirectToAction("TasksMenu");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
