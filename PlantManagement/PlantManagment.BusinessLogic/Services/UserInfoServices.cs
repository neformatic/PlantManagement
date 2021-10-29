using AutoMapper;
using PlantManagment.BusinessLogic.Interface;
using PlantManagment.BusinessLogic.Mapper;
using PlantManagment.BusinessLogic.Models;
using PlantManagment.DataAccessLayer.DataModels;
using PlantManagment.DataAccessLayer.Interface;
using PlantManagment.DataAccessLayer.Models;
using PlantManagment.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.BusinessLogic.Services
{
    public class UserInfoServices : IUserInfoServices
    {
        private PlantManagmentContext _db;
        private IUserInfoRepository _userInfoRepository;
        private IMapper _mapper;

        public UserInfoServices()
        {
            _db = new PlantManagmentContext();
            _userInfoRepository = new UserInfoRepository(_db);
            _mapper = new MapperConfig().Mapper;
        }

        public List<UserInfoModel> GetUserInfo(int id)
        {
            var info = _userInfoRepository.GetUserInfo(id);
            var mapped = new List<UserInfoModel>();
            foreach (var i in info)
            {
                mapped.Add(_mapper.Map<UserInfoModel>(i));
            }
            return mapped;
        }

        public List<UserInfoModel> GetUserInfo()
        {
            var info = _userInfoRepository.GetUserInfo();
            var mapped = new List<UserInfoModel>();
            foreach (var i in info)
            {
                mapped.Add(_mapper.Map<UserInfoModel>(i));
            }
            return mapped;
        }

        public void ChangeStatus(int id, int status)
        {
            _userInfoRepository.ChangeStatus(id, status);
            _db.SaveChanges();
        }
    }
}
