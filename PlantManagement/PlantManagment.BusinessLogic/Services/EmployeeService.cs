using Microsoft.EntityFrameworkCore;
using PlantManagment.BusinessLogic.Interface;
using PlantManagment.BusinessLogic.Models;
using PlantManagment.DataAccessLayer.DataModels;
using PlantManagment.DataAccessLayer.Interface;
using PlantManagment.DataAccessLayer.Models;
using PlantManagment.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlantManagment.BusinessLogic.Services
{
    public class EmployeeService : IEmployeeService
    {
        private PlantManagmentContext _db;
        private IEmployeeRepository _employeeRepository;
        public EmployeeService()
        {
            _db = new PlantManagmentContext();
            _employeeRepository = new EmployeeRepository(_db);
        }
        public int GetEmployeId(int id)
        {
            var userId = _employeeRepository.GetEmployeId(id);
            return userId;
        }
    }
}
