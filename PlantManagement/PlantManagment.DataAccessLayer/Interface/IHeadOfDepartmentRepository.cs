using PlantManagment.DataAccessLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.DataAccessLayer.Interface
{
    public interface IHeadOfDepartmentRepository
    {
        List<EmployeeDataModel> GetEmployeeList();
        void DeleteEmployee(int id);
        List<PositionDataModel> GetPositionInfo();
        List<DepartmentDataModel> GetDepartmentInfo();
        List<EmployeeDataModel> GetUserInfo(string department);
        List<ProjectDataModel> GetProjectInfo();
        List<EmployeeProjectDataModel> GetEmployeeTask();
        void AddEmployeeTask(string task, int projectId, int employeeId);
        List<EmployeeTasksDataModel> GetEmployeeTasks();
    }
}

