using PlantManagment.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.DataAccessLayer.DataModels
{
    public partial class AccountStatusDataModel
    {  
        public int Id { get; set; }
        public string StatusName { get; set; }
        public int StatusId { get; set; } 
    }
}
