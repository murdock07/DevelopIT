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
