using PlantManagment.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.DataAccessLayer.DataModels
{
    public partial class PositionDataModel
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
        public int DepartmnetId { get; set; }
    }
}
