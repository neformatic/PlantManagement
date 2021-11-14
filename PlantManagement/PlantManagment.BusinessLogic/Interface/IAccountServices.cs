using PlantManagment.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.BusinessLogic.Interface
{
    public interface IAccountServices
    {
        void UserRegistration(string login, string password);
        bool IsUser(string login, string password);
        void UserRegistration(string accountLogin, string accountPassword, int accountStatusId);
        void AddUser(string login, string password, string department, string lastName, string firstName, string middleName);
        List<PositionModel> GetPositionsList();
        AccountModel GetUserBylogin(string login);
        string GetUserStatusByAccountStatusId(int statusId);
        string GetRole(int id);
        int GetUserId(string login);
    }
}
