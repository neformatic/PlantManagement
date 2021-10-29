using System;
using System.Collections.Generic;

#nullable disable

namespace PlantManagment.DataAccessLayer.Models
{
    public partial class Account
    {
        public Account()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string AccountLogin { get; set; }
        public string AccountPassword { get; set; }
        public int AccountStatusId { get; set; }

        public virtual AccountStatus AccountStatus { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
