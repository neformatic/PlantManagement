using PlantManagment.DataAccessLayer.DataModels;
using PlantManagment.DataAccessLayer.Interface;
using PlantManagment.DataAccessLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace PlantManagment.DataAccessLayer.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private PlantManagmentContext _context;

        public AccountRepository(PlantManagmentContext context)
        {
            _context = context;
        }

        public void UserRegistration(string login, string password)
        {
            var userLogin = new Account
            {
                AccountLogin = login,
                AccountPassword = password,
                AccountStatusId = 3
            };
            _context.Accounts.Add(userLogin);
        }

        public bool IsUser(string login, string password)
        {
            var userAccount = _context.Accounts.Where(a => a.AccountLogin == login && a.AccountPassword == password).FirstOrDefault();
            return userAccount != null;
        }

        public void CreateUserInfo(string login, string position, string lastName, string firstName, string middleName)
        {
            int userId = _context.Accounts.Where(u => u.AccountLogin == login).Select(u => u.Id).SingleOrDefault();
            int positionId = _context.Positions.Where(p => p.PositionName == position).Select(p => p.Id).SingleOrDefault();
            int depId = _context.Positions.Where(d => d.PositionName == position).Select(d => d.DepartmnetId).SingleOrDefault();
            var userInfo = new Employee
            {
                LastName = lastName,
                FirstName = firstName,
                MiddleName = middleName,
                AccountId = userId,
                DepartmentId = depId,
                PositionId = positionId
            };
            _context.Employees.Add(userInfo);
        }

        public List<PositionDataModel> GetPositionsList()
        {
            var positions = _context.Positions.Select(p => new PositionDataModel
            {
                DepartmnetId = p.DepartmnetId,
                Id = p.Id,
                PositionName = p.PositionName
            }).ToList();
            return positions;
        }
        public AccountDataModel GetUserByLogin(string login)
        {
            var userByLogin = _context.Accounts.Where(u => u.AccountLogin == login).Select(u => new AccountDataModel // проекция вернуть датамодель
            {
                AccountLogin = u.AccountLogin,
                AccountPassword = u.AccountPassword,
                AccountStatusId = u.AccountStatusId,
                Id = u.Id
            }).SingleOrDefault();
            return userByLogin;
        }

        public string GetUserStatusByAccountStatusId(int statusId)
        {
            var userStatus = _context.AccountStatuses.Where(u => u.StatusId == statusId).Select(u => u.StatusName).SingleOrDefault().ToString();
            return userStatus; 
        }
    }
}
