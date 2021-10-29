using PlantManagment.DataAccessLayer.DataModels;
using PlantManagment.DataAccessLayer.Interface;
using PlantManagment.DataAccessLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace PlantManagment.DataAccessLayer.Repositories
{
    public class UserInfoRepository : IUserInfoRepository
    {
        private PlantManagmentContext _db;

        public UserInfoRepository(PlantManagmentContext context)
        {
            _db = context;
        }
        public List<UserInfoDataModel> GetUserInfo(int id)
        {
            var info = (from e in _db.Employees
                        join d in _db.Departments on e.DepartmentId equals d.Id
                        join p in _db.Positions on e.PositionId equals p.Id
                        join t in _db.Tasks on e.Id equals t.EmployeeId
                        join pr in _db.Projects on t.ProjectId equals pr.Id
                        where e.Id == id
                        select new UserInfoDataModel
                        {
                            Id = t.Id,
                            FirstName = e.FirstName,
                            MiddleName = e.MiddleName,
                            LastName = e.LastName,
                            Department = d.DepartmentName,
                            Position = p.PositionName,
                            Project = pr.ProjectName,
                            Task = t.TaskName,
                            TaskStatus = t.TaskStatus
                        }).ToList();
            return info;
        }

        public List<UserInfoDataModel> GetUserInfo()
        {
            var info = (from e in _db.Employees
                        join d in _db.Departments on e.DepartmentId equals d.Id
                        join p in _db.Positions on e.PositionId equals p.Id
                        join t in _db.Tasks on e.Id equals t.EmployeeId
                        join pr in _db.Projects on t.ProjectId equals pr.Id
                        select new UserInfoDataModel
                        {
                            Id = t.Id,
                            FirstName = e.FirstName,
                            MiddleName = e.MiddleName,
                            LastName = e.LastName,
                            Department = d.DepartmentName,
                            Position = p.PositionName,
                            Project = pr.ProjectName,
                            Task = t.TaskName,
                            TaskStatus = t.TaskStatus
                        }).ToList();
            return info;
        }

        public void ChangeStatus(int id, int status)
        {
            var task = _db.Tasks.Where(t => t.Id == id).FirstOrDefault();
            task.TaskStatus = status;
        }       
    }
}
