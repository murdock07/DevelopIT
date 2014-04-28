using Adatkezelő;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectingCompanies.Interface
{
    interface IUserHandler
    {
        void CreateGroupAdmin(int groupId, int userId);
        User CreateUser();
        void DeleteUser(int userId);
        User GetUser(int userId);
        void saveUserProfileDatas(int userId, String name, String address, String birthPlace, DateTime birthDate, String description, String rank);
        String saveUserAvatar(int userId, String url);
        String getUserAvatarPath(int userId);
    }

    interface IGroupHandler
    {
        Group CreateGroup();
        void DeleteGroup(int groupId);
        Group getGroup(int groupId);
        void saveGroupDatas(int userId, int groupId, String groupName, String groupAddress, String groupMailAddress, DateTime dateOfFounding, String groupDescription);
        void userHavePermission(int userId);
        String saveGroupAvatar(int userId, int groupId, String url);
        String getGroupAvatarPath(int groupId);
    }
}
