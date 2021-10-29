using PlantManagment.DataAccessLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.DataAccessLayer.Interface
{
    public interface IHeadOfDepartmentRepository
    {
        public List<EmployeeDataModel> GetEmployeeList();
        public void DeleteEmployee(int id);
        public List<PositionDataModel> GetPositionInfo();
        public List<DepartmentDataModel> GetDepartmentInfo();
        public List<EmployeeDataModel> GetUserInfo(string department);
        public List<ProjectDataModel> GetProjectInfo();
        public List<EmployeeProjectDataModel> GetEmployeeTask();
        public void AddEmployeeTask(string task, int projectId, int employeeId);
    }
}

