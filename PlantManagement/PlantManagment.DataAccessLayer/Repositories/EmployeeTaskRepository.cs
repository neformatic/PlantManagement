using PlantManagment.DataAccessLayer.DataModels;
using PlantManagment.DataAccessLayer.Interface;
using PlantManagment.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlantManagment.DataAccessLayer.Repositories
{
    public class EmployeeTaskRepository : IEmployeeTaskRepository
    {
        private PlantManagmentContext _db;

        public EmployeeTaskRepository(PlantManagmentContext context)
        {
            _db = context;
        }
        public List<Task> GetTasks()
        {
            var task = _db.Tasks.Select(t => new Task
            {
                Id = t.Id,
                EmployeeId = t.EmployeeId,
                ProjectId = t.ProjectId,
                TaskName = t.TaskName,
                TaskStatus = t.TaskStatus
            }).ToList();
            return task;
        }
    }
}
