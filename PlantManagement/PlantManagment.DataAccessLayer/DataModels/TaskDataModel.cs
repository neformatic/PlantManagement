using PlantManagment.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.DataAccessLayer.DataModels
{
    public partial class TaskDataModel
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public int ProjectId { get; set; }
        public int? EmployeeId { get; set; }
        public int TaskStatus { get; set; } 
    }
}
