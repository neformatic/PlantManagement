using System;
using System.Collections.Generic;
using System.Text;
using PlantManagment.DataAccessLayer.Models;

namespace PlantManagment.DataAccessLayer.Interface
{
    public interface IEmployeeTaskRepository
    {
        List<Task> GetTasks();
    }
}
