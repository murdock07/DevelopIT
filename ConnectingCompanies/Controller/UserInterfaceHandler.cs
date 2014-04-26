using Adatkezelő;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectingCompanies.Interface;
using System.Data;

namespace ConnectingCompanies.Controller
{
    public class UserHandler : IUserHandler
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

        public void saveUserProfileDatas(int userId, string name, string address, string birthPlace, DateTime birthDate, string description, string rank)
        {
            using (var entity = new nyilvantartasEntities())
            {
                var loginUser = from x in entity.felhasznalok
                                where x.Id == userId
                                select x;
                felhasznalok felh = loginUser.First();
                felh.nev = name;
                felh.lakhely = address;
                felh.szuletesi_hely = birthPlace;
                felh.szuletesi_ido = birthDate;
                felh.leiras = description;
                felh.beosztas = rank;

                entity.felhasznalok.Attach(felh);
                entity.Entry(felh).State = EntityState.Modified;
                entity.SaveChanges();
            }
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
