using PlantManagment.DataAccessLayer.DataModels;
using System;
using System.Collections.Generic;

#nullable disable

namespace PlantManagment.DataAccessLayer.Models
{
    public partial class AccountStatus
    {
        public AccountStatus()
        {
            Accounts = new HashSet<Account>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; }
        public int StatusId { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
