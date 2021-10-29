using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.BusinessLogic.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        public string AccountLogin { get; set; }
        public string AccountPassword { get; set; }
        public int AccountStatusId { get; set; }
    }
}
