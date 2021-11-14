using AutoMapper;
using PlantManagment.BusinessLogic.Interface;
using PlantManagment.BusinessLogic.Mapper;
using PlantManagment.BusinessLogic.Models;
using PlantManagment.DataAccessLayer.Interface;
using PlantManagment.DataAccessLayer.Models;
using PlantManagment.DataAccessLayer.Repositories;
using System.Collections.Generic;

namespace PlantManagment.BusinessLogic.Services
{
    public class EmployeeTaskServices : IEmployeeTaskServices
    {
        private PlantManagmentContext _db;
        private IEmployeeTaskRepository _employeeTaskRepository;
        private IMapper _mapper;

        public EmployeeTaskServices()
        {
            _db = new PlantManagmentContext();
            _employeeTaskRepository = new EmployeeTaskRepository(_db);
            _mapper = new MapperConfig().Mapper;
        }

        public List<TaskModel> ShowEmployeeTask()
        {
            var tasks = _employeeTaskRepository.GetTasks();
            var mappedModel = new List<TaskModel>();
            foreach (var item in tasks)
            {
                mappedModel.Add(_mapper.Map<TaskModel>(item));
            }
            return mappedModel;
        }
    }
}
