using System;
using System.Collections.Generic;

#nullable disable

namespace PlantManagment.DataAccessLayer.Models
{
    public partial class Task
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public int ProjectId { get; set; }
        public int? EmployeeId { get; set; }
        public int TaskStatus { get; set; }

        public virtual Project Project { get; set; }
    }
}
