using AutoMapper;
using PlantManagment.BusinessLogic.Models;
using PlantManagment.DataAccessLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.BusinessLogic.Mapper
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<AccountDataModel, AccountModel>();
            CreateMap<AccountModel, AccountDataModel>();
            CreateMap<AccountStatusDataModel, AccountStatusModel>();
            CreateMap<AccountStatusModel, AccountStatusDataModel>();
            CreateMap<DepartmentDataModel, DepartmentModel>();
            CreateMap<DepartmentModel, DepartmentDataModel>();
            CreateMap<EmployeeDataModel, EmployeeModel>();
            CreateMap<EmployeeModel, EmployeeDataModel>();
            CreateMap<PositionDataModel, PositionModel>();
            CreateMap<PositionModel, PositionDataModel>();
            CreateMap<ProjectDataModel, ProjectModel>();
            CreateMap<ProjectModel, ProjectDataModel>();
            CreateMap<TaskDataModel, TaskModel>();
            CreateMap<TaskModel, TaskDataModel>();
            CreateMap<UserInfoDataModel, UserInfoModel>();
            CreateMap<UserInfoModel, UserInfoDataModel>();
            CreateMap<EmployeeProjectDataModel, EmployeeProjectModel>();
            CreateMap<EmployeeProjectModel, EmployeeProjectDataModel>();
        }
    }
}
