using System;
using System.Collections.Generic;

#nullable disable

namespace PlantManagment.DataAccessLayer.Models
{
    public partial class Position
    {
        public Position()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string PositionName { get; set; }
        public int DepartmnetId { get; set; }

        public virtual Department Departmnet { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
