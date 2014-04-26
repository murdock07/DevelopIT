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
        void saveUserProfileDatas(int userId, string name, string address, string birthPlace, DateTime birthDate, string description, string rank);
    }

    interface IGroupHandler
    {
        Group CreateGroup();
        void DeleteGroup(int groupId);
        Group getGroup(int groupId);
    }
}
