using AutoMapper;
using PlantManagment.BusinessLogic.Interface;
using PlantManagment.BusinessLogic.Models;
using PlantManagment.DataAccessLayer.Interface;
using PlantManagment.DataAccessLayer.Models;
using PlantManagment.DataAccessLayer.Repositories;
using System.Collections.Generic;

namespace PlantManagment.BusinessLogic.Services
{
    public class ProjectService : IProjectService
    {
        private PlantManagmentContext _db;
        private IProjectRepository _projectRepository;
        private IMapper _mapper;

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

        public List<string> GetProjects()
        {
            var projects =_projectRepository.GetProjects();
            return projects;
        }

        public int GetProjectId(string projectName)
        {
           var projectId = _projectRepository.GetProjectId(projectName);
            return projectId;
        }
    }

}
