using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.BusinessLogic.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public int AccountId { get; set; }
        public int DepartmentId { get; set; }
        public string Position { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
    }
}
