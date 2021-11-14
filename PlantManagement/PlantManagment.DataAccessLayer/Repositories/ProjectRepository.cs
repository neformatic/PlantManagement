using PlantManagment.DataAccessLayer.DataModels;
using PlantManagment.DataAccessLayer.Interface;
using PlantManagment.DataAccessLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace PlantManagment.DataAccessLayer.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private PlantManagmentContext _db;

        public ProjectRepository(PlantManagmentContext context)
        {
            _db = context;
        }
        public void AddProject(string projectName)
        {
            Project project = new Project();
            project.ProjectName = projectName;
            _db.Projects.Add(project);
        }

        public List<string>GetProjects()
        {
            var projects = _db.Projects.Select(p => p.ProjectName).ToList();
            return projects;
        }
        public int GetProjectId(string projectName)
        {
            var project = _db.Projects.Where(p => p.ProjectName == projectName).Select(p=>p.Id).FirstOrDefault();
            return project;
        }
    }
}


