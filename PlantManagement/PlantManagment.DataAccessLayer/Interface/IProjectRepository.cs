using PlantManagment.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.DataAccessLayer.Interface
{
    public interface IProjectRepository
    {
        void AddProject(string projectName);
        List<string> GetProjects();
        int GetProjectId(string projectName);
    }
}
