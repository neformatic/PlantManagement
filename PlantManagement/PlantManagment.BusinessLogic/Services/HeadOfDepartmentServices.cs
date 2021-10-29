using AutoMapper;
using PlantManagment.BusinessLogic.Interface;
using PlantManagment.BusinessLogic.Mapper;
using PlantManagment.BusinessLogic.Models;
using PlantManagment.DataAccessLayer.DataModels;
using PlantManagment.DataAccessLayer.Interface;
using PlantManagment.DataAccessLayer.Models;
using PlantManagment.DataAccessLayer.Repositories;
using System.Collections.Generic;

namespace PlantManagment.BusinessLogic.Services
{
    public class HeadOfDepartmentServices : IHeadOfDepartmentServices
    {
        private PlantManagmentContext _db;
        private IHeadOfDepartmentRepository _headOfDepartmentRepository;
        private IMapper _mapper;

        public HeadOfDepartmentServices()
        {
            _db = new PlantManagmentContext();
            _headOfDepartmentRepository = new HeadOfDepartmentRepository(_db);
            _mapper = new MapperConfig().Mapper;
        }
        public List<EmployeeModel> ShowEmployeeList()
        {
            var employee = _headOfDepartmentRepository.GetEmployeeList();
            var mappedModel = new List<EmployeeModel>();
            foreach (var e in employee)
            {
                mappedModel.Add(_mapper.Map<EmployeeModel>(e));
            }
            return mappedModel;
        }

        public void ShowDeleteEmployee(int id)
        {
            _headOfDepartmentRepository.DeleteEmployee(id);
        }
        public List<PositionModel> ShowPositionInfo()
        {
            var position = _headOfDepartmentRepository.GetPositionInfo();
            var mappedModel = new List<PositionModel>();
            foreach (var p in position)
            {
                mappedModel.Add(_mapper.Map<PositionModel>(p));
            }
            return mappedModel;
        }
        public List<DepartmentModel> ShowDepartmentInfo()
        {
            var department = _headOfDepartmentRepository.GetDepartmentInfo();
            var mappedModel = new List<DepartmentModel>();
            foreach (var d in department)
            {
                mappedModel.Add(_mapper.Map<DepartmentModel>(d));
            }
            return mappedModel;
        }

        public List<EmployeeModel> ShowUserInfo(string department)
        {
            var userInfo = _headOfDepartmentRepository.GetUserInfo(department);
            var mappedModel = new List<EmployeeModel>();
            foreach (var e in userInfo)
            {
                mappedModel.Add(_mapper.Map<EmployeeModel>(e));
            }
            return mappedModel;
        }
        public List<ProjectModel> ShowProjectInfo()
        {
            var project = _headOfDepartmentRepository.GetProjectInfo();
            var mappedModel = new List<ProjectModel>();
            foreach (var p in project)
            {
                mappedModel.Add(_mapper.Map<ProjectModel>(p));
            }
            return mappedModel;
        }
        public void AddEmployeeTask(string taskEmployee, int projectId, int employeeId)
        {
            _headOfDepartmentRepository.AddEmployeeTask(taskEmployee, projectId, employeeId);
            _db.SaveChanges();
        }
    }
}
