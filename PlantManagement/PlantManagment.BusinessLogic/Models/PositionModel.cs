using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.BusinessLogic.Models
{
    public class PositionModel
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
        public int DepartmnetId { get; set; }
    }
}
