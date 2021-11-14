using Microsoft.EntityFrameworkCore;
using PlantManagment.DataAccessLayer.DataModels;
using PlantManagment.DataAccessLayer.Interface;
using PlantManagment.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlantManagment.DataAccessLayer.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private PlantManagmentContext _db;

        public EmployeeRepository(PlantManagmentContext db)
        {
            _db = db;
        }
        public List<Employee> GetUsers()
        {
            var userInfo = _db.Employees.FromSqlRaw("EmployeeInfo").ToList();
            return userInfo;
        }
        public int GetEmployeId(int id)
        {
            var userId = (from u in _db.Employees
                          join a in _db.Accounts on u.AccountId equals a.Id
                          where a.Id == id
                          select u.Id).FirstOrDefault();
            return userId;
        }

        public int GetEmployeeIdByEmployeeName(string employeeName)
        {
           var employeeId = _db.Employees.Where(e => e.LastName + e.FirstName + e.MiddleName == employeeName).Select(p => p.Id).FirstOrDefault();
            return employeeId;
        }
    }
}
