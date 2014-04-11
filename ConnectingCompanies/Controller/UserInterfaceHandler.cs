using Adatkezelő;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectingCompanies.Controller
{
    public class UserHandler
    {

        public UserHandler()
        {

        }

        /// 
        /// <param name="groupId"></param>
        /// <param name="userId"></param>
        public void CreateGroupAdmin(int groupId, int userId)
        {

        }

        public User CreateUser()
        {

            return null;
        }

        /// 
        /// <param name="userId"></param>
        public void DeleteUser(int userId)
        {

        }

        /// 
        /// <param name="userId"></param>
        public User GetUser(int userId)
        {

            return null;
        }

    }

    public class GroupHandler
    {

        public Group m_Group;

        public GroupHandler()
        {

        }

        public Group CreateGroup()
        {
            return null;
        }

        /// 
        /// <param name="groupId"></param>
        public void DeleteGroup(int groupId)
        {

        }

        /// 
        /// <param name="groupId"></param>
        public Group getGroup(int groupId)
        {
            return null;
        }
    }
}
