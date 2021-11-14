using PlantManagment.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.DataAccessLayer.Interface
{
    public interface IEmployeeRepository
    {
        List<Employee> GetUsers();
        int GetEmployeId(int id);
        int GetEmployeeIdByEmployeeName(string employeeName);
    }
}
