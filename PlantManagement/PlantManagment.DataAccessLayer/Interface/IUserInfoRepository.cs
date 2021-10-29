using PlantManagment.DataAccessLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.DataAccessLayer.Interface
{
    public interface IUserInfoRepository
    {
        List<UserInfoDataModel> GetUserInfo(int id);
        List<UserInfoDataModel> GetUserInfo();
        void ChangeStatus(int id, int status);
    }
}
