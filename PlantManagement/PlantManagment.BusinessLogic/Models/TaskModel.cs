using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.BusinessLogic.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public int ProjectId { get; set; }
        public int? EmployeeId { get; set; }
        public int TaskStatus { get; set; }
    }
}
