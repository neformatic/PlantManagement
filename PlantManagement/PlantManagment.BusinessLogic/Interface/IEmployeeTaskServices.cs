using PlantManagment.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.BusinessLogic.Interface
{
    public interface IEmployeeTaskServices
    {
        List<TaskModel> ShowEmployeeTask();
    }
}
