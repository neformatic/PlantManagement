using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantManagment.Web.Models
{
    public class RegistrationViewModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
    }
}
