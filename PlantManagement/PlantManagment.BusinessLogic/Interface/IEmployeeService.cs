using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.BusinessLogic.Interface
{
    public interface IEmployeeService
    {
        int GetEmployeId(int id);
        int GetEmployeeIdByEmployeeName(string employeeName);
    }
}
