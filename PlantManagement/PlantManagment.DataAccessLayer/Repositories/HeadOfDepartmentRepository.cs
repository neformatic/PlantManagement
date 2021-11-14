using Microsoft.EntityFrameworkCore;
using PlantManagment.DataAccessLayer.DataModels;
using PlantManagment.DataAccessLayer.Interface;
using PlantManagment.DataAccessLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace PlantManagment.DataAccessLayer.Repositories
{
    public class HeadOfDepartmentRepository : IHeadOfDepartmentRepository
    {
        private PlantManagmentContext _db;

        public HeadOfDepartmentRepository(PlantManagmentContext context)
        {
            _db = context;
        }
        public List<EmployeeDataModel> GetEmployeeList()
        {
            var employees = (from e in _db.Employees
                             join p in _db.Positions on e.PositionId equals p.Id
                             select new EmployeeDataModel
                             {
                                 Id = e.Id,
                                 AccountId = e.AccountId,
                                 DepartmentId = e.DepartmentId,
                                 FirstName = e.FirstName,
                                 LastName = e.LastName,
                                 MiddleName = e.MiddleName,
                                 Position = p.PositionName
                             }).ToList();
            return employees;
        }
        public void DeleteEmployee(int id)
        {
            var employee = _db.Employees.Find(id);
            _db.Employees.Remove(employee);
            _db.SaveChanges();
        }
        public List<PositionDataModel> GetPositionInfo()
        {
            var position = _db.Positions.Select(p => new PositionDataModel
            {
                DepartmnetId = p.DepartmnetId,
                Id = p.Id,
                PositionName = p.PositionName
            }).ToList();
            return position;
        }
        public List<DepartmentDataModel> GetDepartmentInfo()
        {
            var department = _db.Departments.Select(d => new DepartmentDataModel
            {
                Id = d.Id,
                DepartmentName = d.DepartmentName
            }).ToList();
            return department;
        }
        public List<EmployeeDataModel> GetUserInfo(string department)
        {
            var employee = (from emp in _db.Employees
                            join dep in _db.Departments on emp.DepartmentId equals dep.Id
                            where dep.DepartmentName == department
                            select new EmployeeDataModel
                            {
                                Id = emp.Id,
                                LastName = emp.LastName,
                                MiddleName = emp.MiddleName,
                                FirstName = emp.FirstName
                            }).ToList();
            return employee;
        }
        public List<ProjectDataModel> GetProjectInfo()
        {
            var project = _db.Projects.Select(p => new ProjectDataModel
            {
                Id = p.Id,
                ProjectName = p.ProjectName
            }).ToList();
            return project;
        }
        public List<EmployeeProjectDataModel> GetEmployeeTask()
        {
            var employeeTask = _db.EmployeeProjects.Select(ep => new EmployeeProjectDataModel
            {
                Id = ep.Id,
                EmployeeId = ep.EmployeeId,
                ProjectId = ep.ProjectId
            }).ToList();
            return employeeTask;
        }
        public void AddEmployeeTask(string task, int projectId, int employeeId)
        {
            Task taskEmployee = new Task()
            {
                EmployeeId = employeeId,
                ProjectId = projectId,
                TaskName = task,
                TaskStatus = 0
            };
            _db.Tasks.Add(taskEmployee);
        }

        public List<EmployeeTasksDataModel> GetEmployeeTasks()
        {
            var employees = _db.Employees.ToList();
            var tasks = _db.Tasks.ToList();
            foreach (var task in tasks)
            {
                _db.Employees.Where(t => t.Id == task.Id).Load();
                _db.Projects.Where(p => p.Id == task.ProjectId).Load();
            }
            List<EmployeeTasksDataModel> employeeTasks= new List<EmployeeTasksDataModel>();
            foreach (var item in employees)
            {
                var employeeTaskModel = new EmployeeTasksDataModel
                {
<<<<<<< HEAD
                    FullName = item.LastName + " " + item.FirstName + " " + item.MiddleName,
=======
                    FullName = item.LastName + item.FirstName + item.MiddleName,
>>>>>>> 63851a315ec8051887d613819941c215fc5740fc
                    Tasks = tasks.Where(t => t.EmployeeId == item.Id).Select(t => new TaskDataModel
                    {
                        Id = t.Id,
                        EmployeeId = t.EmployeeId,
                        ProjectId = t.ProjectId,
                        TaskName = t.TaskName,
                        TaskStatus = t.TaskStatus
                    }).ToList(),
                    Project = null
                };
                employeeTasks.Add(employeeTaskModel);
            }
            
            return employeeTasks;
        }
    }
}


//var employeeTasks = (from t in _db.Tasks
//                     join e in _db.Employees on t.EmployeeId equals e.Id
//                     join p in _db.Projects on t.ProjectId equals p.Id
//                     select new EmployeeTasksDataModel
//                     {
//                         FullName = e.LastName + e.FirstName + e.MiddleName,
//                         Project = p.ProjectName,
//                         Tasks = _db.Tasks.Where(i => i.EmployeeId == e.Id).Select(i => new TaskDataModel
//                         {
//                             TaskName = i.TaskName,
//                             Id = i.Id,
//                             EmployeeId = i.EmployeeId,
//                             ProjectId = i.ProjectId,
//                             TaskStatus = i.TaskStatus
//                         }).ToList()
//                     }).ToList();
//return employeeTasks