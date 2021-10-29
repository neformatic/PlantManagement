using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.BusinessLogic.Models
{
    public class UserInfoModel
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Project { get; set; }
        public string Task { get; set; }
        public int TaskStatus { get; set; }
    }
}
