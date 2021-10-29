using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.DataAccessLayer.DataModels
{
    public class EmployeeProjectDataModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }
    }
}
