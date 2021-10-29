using System;
using System.Collections.Generic;

#nullable disable

namespace PlantManagment.DataAccessLayer.Models
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeProjects = new HashSet<EmployeeProject>();
        }
        public int Id { get; set; }
        public string LastName { get; set; }
        public int AccountId { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public virtual Account Account { get; set; }
        public virtual Department Department { get; set; }
        public virtual Position Position { get; set; }
        public virtual ICollection<EmployeeProject> EmployeeProjects { get; set; }
    }
}
