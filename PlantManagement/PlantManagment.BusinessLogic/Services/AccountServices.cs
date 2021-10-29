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
    public class AccountServices : IAccountServices
    {
        private PlantManagmentContext _db;
        private IMapper _mapper;
        private IAccountRepository _repository;

        public AccountServices()
        {
            _db = new PlantManagmentContext();
            _mapper = new MapperConfig().Mapper;
            _repository = new AccountRepository(_db);
        }

        public void UserRegistration(string login, string password)
        {
            _repository.UserRegistration(login, password);
            _db.SaveChanges();
        }

        public bool IsUser(string login, string password)
        {
            var userAccount = _repository.IsUser(login, password);
            return userAccount;
        }

        public void UserRegistration(string accountLogin, string accountPassword, int accountStatusId)
        {
            var userLogin = new Account
            {
                AccountLogin = accountLogin,
                AccountPassword = accountPassword,
                AccountStatusId = accountStatusId
            };
            _db.Accounts.Add(userLogin);
            _db.SaveChanges();
        }

        public void AddUser(string login, string password, string deparment, string lastName, string firstName, string middleName )
        {
            UserRegistration(login, password);
            _repository.CreateUserInfo(login, deparment, lastName, firstName, middleName);
        }

        public List<PositionModel> GetPositionsList()
        {
            var positions = _repository.GetPositionsList();
            List<PositionModel> positionModels = new List<PositionModel>();
            foreach (var item in positions)
            {
                var mapped = _mapper.Map<PositionModel>(item);
                positionModels.Add(mapped);
            }
            return positionModels;
        }

        public AccountModel GetUserBylogin(string login)
        {
            var user = _repository.GetUserByLogin(login);
            var mapped = _mapper.Map<AccountModel>(user);
            return mapped;
        }

        public string GetUserStatusByAccountStatusId(int statusId)
        {
            var user = _repository.GetUserStatusByAccountStatusId(statusId);
           
            return user;
        }
    }
}