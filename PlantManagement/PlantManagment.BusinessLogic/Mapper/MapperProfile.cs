using AutoMapper;
using PlantManagment.BusinessLogic.Models;
using PlantManagment.DataAccessLayer.DataModels;
using PlantManagment.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.BusinessLogic.Mapper
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<AccountDataModel, AccountModel>().ReverseMap();
            CreateMap<AccountStatusDataModel, AccountStatusModel>().ReverseMap();
            CreateMap<DepartmentDataModel, DepartmentModel>().ReverseMap();
            CreateMap<EmployeeDataModel, EmployeeModel>().ReverseMap();
            CreateMap<EmployeeTasksDataModel, EmployeeTasksModel>().ReverseMap();
            CreateMap<PositionDataModel, PositionModel>().ReverseMap();
            CreateMap<ProjectDataModel, ProjectModel>().ReverseMap();
            CreateMap<TaskDataModel, TaskModel>().ReverseMap();
            CreateMap<TaskModel, Task>().ReverseMap();
            CreateMap<UserInfoDataModel, UserInfoModel>().ReverseMap();
            CreateMap<EmployeeProjectDataModel, EmployeeProjectModel>().ReverseMap();
        }
    }
}
