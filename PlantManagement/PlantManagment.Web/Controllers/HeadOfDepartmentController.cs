using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using PlantManagment.BusinessLogic.Services;
using PlantManagment.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PlantManagment.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HeadOfDepartmentController : Controller
    {
        private HeadOfDepartmentServices _headOfDepartmentServices;
        private AccountServices _accountServices;
        private EmployeeTaskServices _taskServices;
        private ProjectService _projectService;
        private EmployeeService _employeeService;

        public HeadOfDepartmentController(AccountServices accountServices, HeadOfDepartmentServices headOfDepartmentServices, EmployeeTaskServices taskServices, ProjectService projectService, EmployeeService employeeService)
        {
            _headOfDepartmentServices = headOfDepartmentServices;
            _accountServices = accountServices;
            _taskServices = taskServices;
            _projectService = projectService;
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult AdminMenu()
        {
            var tasksList = _headOfDepartmentServices.GetEmployeeTasks();
            var projectList = _projectService.GetProjects();
            List<HeadOfDepartmentViewModel> employeeViewModel = new List<HeadOfDepartmentViewModel>();

            foreach (var item in tasksList)
            {
                List<TaskViewModel> taskViewModel = new List<TaskViewModel>();
                foreach (var task in item.Tasks)
                {
                    var taskEmployee = new TaskViewModel
                    {
                        EmployeeId = task.EmployeeId,
                        Id = task.Id,
                        ProjectId = task.ProjectId,
                        TaskName = task.TaskName,
                        TaskStatus = task.TaskStatus
                    };
                    taskViewModel.Add(taskEmployee);
                }
                HeadOfDepartmentViewModel model = new HeadOfDepartmentViewModel
                {
                    FullName = item.FullName,
                    Tasks = taskViewModel,
                    Projects = projectList
                };
                employeeViewModel.Add(model);
            }
            return View(employeeViewModel);
        }

        [HttpPost]
        public IActionResult AdminMenu(string newTask, string project, string fullName)
        {
            var employeeId = _employeeService.GetEmployeeIdByEmployeeName(fullName);
            var projectId = _projectService.GetProjectId(project);
            _headOfDepartmentServices.AddEmployeeTask(newTask, projectId, employeeId);
            return RedirectToAction("AdminMenu");
        }

        [HttpPost]
        public IActionResult AddProject(string newProject)
        {
            _projectService.AddNewProject(newProject);
            return RedirectToAction("AdminMenu");
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
