using PlantManagment.DataAccessLayer.DataModels;
using PlantManagment.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.DataAccessLayer.Interface
{
    public interface IAccountRepository
    {
        void UserRegistration(string login, string pass);
        bool IsUser(string login, string password);
        void CreateUserInfo(string login, string department, string lastName, string firstName, string middleName);
        List<PositionDataModel> GetPositionsList();
        AccountDataModel GetUserByLogin(string login);
        string GetUserStatusByAccountStatusId(int statusId);
        string GetRole(int id);
        int GetUserId(string login);
        void SaveUser(string accountLogin, string accountPassword, int accountStatusId);
    }
}
