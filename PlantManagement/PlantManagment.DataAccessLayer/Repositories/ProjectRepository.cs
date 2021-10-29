using PlantManagment.DataAccessLayer.DataModels;
using PlantManagment.DataAccessLayer.Interface;
using PlantManagment.DataAccessLayer.Models;

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
    }
}


