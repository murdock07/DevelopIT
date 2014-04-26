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
           List<Adatkezelő.Offer> output=new List<Adatkezelő.Offer>();
           var w = from x in entities.csoportok
                   where x.cegnev.Contains(cName)
                   select x.Id;//cégazonosítók listája melyek nevében szerepel a string
           if (w.Count() != 0)
           {
               var v = from x in entities.ajanlatok
                       where w.Contains(x.kezdo_ceg)
                       select x;//ajánlatok listája
               foreach (var item in v)
               {
                   Adatkezelő.Offer o = new Adatkezelő.Offer(entities, item);
                   output.Add(o);
               }
           }
           return output;
        }
        public List<Adatkezelő.Group> GetGroupsByName(string companyName)
        {//groupok listája amelyek cégneve tartalmazza az átadott stringet
            var v = from x in entities.csoportok
                    where x.cegnev.Contains(companyName)
                    select x;
            List<Adatkezelő.Group> groups = new List<Group>();
            foreach (var item in v)
            {
                Adatkezelő.Group newgroup = new Adatkezelő.Group();
                newgroup.SetAttributesFromDB(item);
                groups.Add(newgroup);
            }
            return groups;
        }
        public List<Adatkezelő.Event> GetEventsByName(string eventname)
        {//események melyek neve tartalmazzák az eventname-t
            List<Adatkezelő.Event> output = new List<Adatkezelő.Event>();
            var v = from x in entities.esemenyek
                    where x.megnevezes.Contains(eventname)
                    select x;
            foreach (var item in v)
            {
                Adatkezelő.Event ev= new Adatkezelő.Event();
                ev.Creator =new Adatkezelő.User( item.letrehozo);
                ev.Date = item.idopont;
                ev.Description = item.leiras;
                ev.Location = item.helyszin;
                ev.Name = item.megnevezes;
                output.Add(ev);
            }
            return output;
        }
        public List<Adatkezelő.User> GetUsersByAddr(string addr)
        {//cím alapján adja vissza
            List<Adatkezelő.User> output = new List<Adatkezelő.User>();
            var v = from x in entities.felhasznalok
                    where x.lakhely.Contains(addr)
                    select x;
            foreach (var item in v)
            {
                output.Add(new Adatkezelő.User(item.Id));
            }
            return output;
        }
        public List<Adatkezelő.Group> GetGroupsByAdd(string add)
        {//telephely alapján
            List<Adatkezelő.Group> output = new List<Adatkezelő.Group>();
            var v = from x in entities.csoportok
                    where x.telephely.Contains(add)
                    select x;
            foreach (var item in v)
            {
                Adatkezelő.Group a = new Adatkezelő.Group();
                a.SetAttributesFromDB(item);
                output.Add(a);
            }
            return output;
        }
        public List<Adatkezelő.Group> GetGroupsByDesc(string desc)
        {//leírás alapján keres
            List<Adatkezelő.Group> output = new List<Adatkezelő.Group>();
            var v = from x in entities.csoportok
                    where x.leiras.Contains(desc)
                    select x;
            foreach (var item in v)
            {
                Adatkezelő.Group a = new Adatkezelő.Group();
                a.SetAttributesFromDB(item);
                output.Add(a);
            }
            return output;
        
        }
        public List<Adatkezelő.User> GetUserByBPlace(string place)
        {
            List<Adatkezelő.User> output = new List<Adatkezelő.User>();
            var v = from x in entities.felhasznalok
                    where x.szuletesi_hely.Contains(place)
                    select x;
            foreach (var item in v)
            {
                output.Add(new Adatkezelő.User(item.Id));
            }
            return output;
        }
        public List<Adatkezelő.Group> GetGroupsByCLeader(string leaderName)
        {
            List<Adatkezelő.Group> output = new List<Adatkezelő.Group>();
            var v = from x in entities.csoportok
                    select x.cegvezeto;//csoportok cégvezetőinek listája
            foreach (var item in v)
            {
                if (item != null)//ha volt vezető..nullable..
                {
                    var ve = from x in entities.felhasznalok
                             where x.Id == item
                             select x;//azon felhasználók akik főnökök//ebből csak 1lesz
                    if (ve.First() != null)
                    {//létezik a felh
                        var w = from x in entities.csoportok
                                where x.cegvezeto ==item
                                select x;//fehasználó objektum
                        Adatkezelő.Group g= new Adatkezelő.Group();
                        g.SetAttributesFromDB(w.First());
                        output.Add(g);
                    }
                }
            }
            return output;
        }
        public List<Adatkezelő.Offer> GetOffersByName(string name)
        {
            List<Adatkezelő.Offer> output = new List<Adatkezelő.Offer>();
            var v = from x in entities.ajanlatok
                    where x.megnevezes.Contains(name)
                    select x;
            foreach (var item in v)
            {
                Adatkezelő.Offer o = new Adatkezelő.Offer(entities,item);
                output.Add(o);
            }

            return output;
        }
        public List<Adatkezelő.Offer> GetOffersByDestCompany(string destC)
        {
            List<Adatkezelő.Offer> output = new List<Adatkezelő.Offer>();
            var v=from x in entities.csoportok  //groupIDk listája amiknek cégeneve tartalmazza a stringet
                  where x.cegnev.Contains(destC)
                  select x.Id;
            
            if(v.Count()!=0)
            {
                var w = from x in entities.ajanlatok
                        where v.Contains(x.fogado_ceg)
                        select x;//megfelelő ajánlatok listája

                foreach (var item in w)
                {//megfelelő ajánlatok=> List<Adatkezelő.Offer>
                    Adatkezelő.Offer o = new Adatkezelő.Offer(entities, item);
                    output.Add(o);
                }
            }
            return output;
        }
        public List<Adatkezelő.User> GetUserByBDate(DateTime bDate)
        {
            List<Adatkezelő.User> output = new List<Adatkezelő.User>();
            var v = from x in entities.felhasznalok
                    where x.szuletesi_ido.Year+x.szuletesi_ido.Month+x.szuletesi_ido.Day==bDate.Year+bDate.Month+bDate.Day//!!!!nem datetime=datetime
                    select x;              
            foreach (var item in v)
            {
                Adatkezelő.User usr = new Adatkezelő.User();
                usr.SetAttributesFromDB(item);
                output.Add(usr);
            }
            return output;
        }
        public List<Adatkezelő.Offer> GetOffersByDateTime(DateTime dTime)
        {//kező és végpont közé esik a megadott időpont
            List<Adatkezelő.Offer> output=new List<Adatkezelő.Offer>();
            var v = from x in entities.ajanlatok
                    where x.kezdes_datum >= dTime && x.zaras_datum != null && x.zaras_datum <= dTime
                    select x;
            foreach (var item in v)
            {
                output.Add( new Adatkezelő.Offer(entities, item));
            }
            return output;
        }
        public List<Adatkezelő.Group> GetGroupsByCreateDate(DateTime dTime)
        {//kező és végpont közé esik a megadott időpont
            List<Adatkezelő.Group> output = new List<Adatkezelő.Group>();
            var v = from x in entities.csoportok
                    where x.alapitas_datuma==dTime//OK?
                    select x;
            foreach (var item in v)
            {
                Adatkezelő.Group g= new Adatkezelő.Group();
                g.SetAttributesFromDB(item);
                output.Add(g);
            }
            return output;
        }
        public List<Adatkezelő.Event> GetEventsByDate(DateTime dateTime)
        {
            List<Adatkezelő.Event> output = new List<Adatkezelő.Event>();

            var v = from x in entities.esemenyek
                    where x.idopont.Year+x.idopont.Month+x.idopont.Day==dateTime.Year+dateTime.Month+dateTime.Day//!!! óra eltérés miatt
                    select x;
            foreach (var item in v)
            {
                output.Add(new Adatkezelő.Event(item));
            }
            return output;
        }
        public List<Adatkezelő.Event> GetEventsByPlace(string place)
        {
            List<Adatkezelő.Event> output = new List<Adatkezelő.Event>();
            var v = from x in entities.esemenyek
                    where x.helyszin.Contains(place)
                    select x;
            foreach (var item in v)
            {
                output.Add(new Adatkezelő.Event(item));
            }
            return output;
        }
    }
}
