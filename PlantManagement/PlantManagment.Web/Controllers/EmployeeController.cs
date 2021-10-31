using Microsoft.AspNetCore.Mvc;
using PlantManagment.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantManagment.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private HeadOfDepartmentServices _headOfDepartmentServices;
        private AccountServices _accountServices;

        public EmployeeController(AccountServices accountServices, HeadOfDepartmentServices headOfDepartmentServices )
        {
            _accountServices = accountServices;
            _headOfDepartmentServices = headOfDepartmentServices;
        }
        [HttpGet]
        public IActionResult Tasks()
        {
            return View();
        }
    }
}
