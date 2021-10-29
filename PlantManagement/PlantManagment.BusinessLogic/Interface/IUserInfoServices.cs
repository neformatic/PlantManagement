using PlantManagment.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.BusinessLogic.Interface
{
    public interface IUserInfoServices
    {
        List<UserInfoModel> GetUserInfo(int id);
        List<UserInfoModel> GetUserInfo();
        void ChangeStatus(int id, int status);
    }
}
