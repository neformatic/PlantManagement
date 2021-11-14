using PlantManagment.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.BusinessLogic.Interface
{
    public interface IProjectService
    {
        void AddNewProject(string projectName);
        List<string> GetProjects();
        int GetProjectId(string projectName);
    }
}
