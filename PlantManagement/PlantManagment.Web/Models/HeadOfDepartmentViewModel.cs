using System.Collections.Generic;

namespace PlantManagment.Web.Models
{
    public class HeadOfDepartmentViewModel
    {
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public List<string> Projects { get; set; }
        public List<TaskViewModel> Tasks { get; set; }
    }
}
