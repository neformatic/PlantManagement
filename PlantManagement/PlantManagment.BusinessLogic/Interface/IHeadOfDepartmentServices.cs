using PlantManagment.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.BusinessLogic.Interface
{
    public interface IHeadOfDepartmentServices
    {
        List<EmployeeModel> ShowEmployeeList();
        void ShowDeleteEmployee(int id);
        List<PositionModel> ShowPositionInfo();
        List<DepartmentModel> ShowDepartmentInfo();
        List<EmployeeModel> ShowUserInfo(string department);
        List<ProjectModel> ShowProjectInfo();
        void AddEmployeeTask(string taskEmployee, int projectId, int employeeId);
    }
}
