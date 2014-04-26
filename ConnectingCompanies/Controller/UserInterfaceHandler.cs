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

  /**/  public class SearchHandler
    {
        nyilvantartasEntities entities = new nyilvantartasEntities();
        public List<Adatkezelő.User> FindUserByName(string username)
        {
            var v = from x in entities.felhasznalok
                    where x.nev.Contains(username)
                    select x;
            List<Adatkezelő.User> output = new List<Adatkezelő.User>();
            foreach (var item in v)
            {
                Adatkezelő.User u = new Adatkezelő.User();
                u.SetAttributesFromDB(item);
                output.Add(u);
            }
            return output;
        }
        public List<Adatkezelő.Offer> FindOfferBySCompany(string cName)
        {//ha tartalmazza a neve a stringet... persze lehetne máshogy is
            //var v = from x in entities.csoportok
            //        where x.cegnev.Contains(cName)
            //        select x;
            //var ve=from x in entities.ajanlatok
            //       where v.Contains(x.
            return new List<Adatkezelő.Offer>();
        }
    }
}
