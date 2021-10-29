using PlantManagment.BusinessLogic.Interface;
using PlantManagment.DataAccessLayer.Interface;
using PlantManagment.DataAccessLayer.Models;
using PlantManagment.DataAccessLayer.Repositories;

namespace PlantManagment.BusinessLogic.Services
{
    public class ProjectService : IProjectService
    {
        private PlantManagmentContext _db;
        private IProjectRepository _projectRepository;

        public ProjectService()
        {
            _db = new PlantManagmentContext();
            _projectRepository = new ProjectRepository(_db);
        }

        public void AddNewProject(string projectName)
        {
            _projectRepository.AddProject(projectName);
            _db.SaveChanges();
        }
    }

}
