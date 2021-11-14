using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantManagment.Web.Models
{
    public class TaskViewModel
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public int ProjectId { get; set; }
        public int? EmployeeId { get; set; }
        public int TaskStatus { get; set; }
    }
}
