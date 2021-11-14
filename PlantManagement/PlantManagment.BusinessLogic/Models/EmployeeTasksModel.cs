using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.DataAccessLayer.DataModels
{
    public class EmployeeTasksModel
    {
        public string FullName { get; set; }
        public string Project { get; set; }
        public List<TaskDataModel> Tasks { get; set; }
    }
}
