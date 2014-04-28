using Adatkezelő;
using ConnectingCompanies;
using ConnectingCompanies.Interface;
using ConnectingCompanies.Exection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConnectingCompanies.Controller
{
    public class UserHandler : IUserHandler
    {
        private static String destionationDir = ".\\uploads";

        public static String DestionationDir
        {
            get { return UserHandler.destionationDir; }
            //set { UserHandler.destionationDir = value; }
        }
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
            var loginUser = from x in MainForm.entities.felhasznalok
                            where x.Id == userId
                            select x;
            if (loginUser.Count() == 0)
            {
                return null;
            }
            else
            {
                User user = new User();
                user.SetAttributesFromDB(loginUser.First());
                return user;
            }
        }

        public void saveUserProfileDatas(int userId, string name, string address, string birthPlace, DateTime birthDate, string description, string rank)
        {
            var loginUser = from x in MainForm.entities.felhasznalok
                            where x.Id == userId
                            select x;
            felhasznalok felh = loginUser.First();
            felh.nev = name;
            felh.lakhely = address;
            felh.szuletesi_hely = birthPlace;
            felh.szuletesi_ido = birthDate;
            felh.leiras = description;
            felh.beosztas = rank;

            MainForm.entities.Entry(felh).State = EntityState.Modified;
            MainForm.entities.SaveChanges();
        }

        public String saveUserAvatar(int userId, String url)
        {
            if (File.Exists(url))
            {
                if (!Directory.Exists(destionationDir))
                {
                    Directory.CreateDirectory(destionationDir);
                }
                String extension = url.Substring(url.LastIndexOf(".") + 1);
                String destinationFileName = userId.ToString() + "_avatar." + extension;
                String destinationPath = Path.Combine(destionationDir, destinationFileName);

                File.Copy(@url, destinationPath, true);
                
                kepek kep = new kepek();
                kep.Id = MainForm.entities.kepek.Count() + 1;
                kep.utvonal = destinationFileName;
                MainForm.entities.kepek.Add(kep);

                var loginUser = from x in MainForm.entities.felhasznalok
                                where x.Id == userId
                                select x;
                felhasznalok felh = loginUser.First();
                felh.profilkep = kep.Id;
                MainForm.entities.felhasznalok.Attach(felh);
                
                MainForm.entities.Entry(felh).State = EntityState.Modified;
                MainForm.entities.SaveChanges();

                return destinationPath;
            }
            else
            {
                throw new FileNotFoundException("A megadott fájl nem létezik!");
            }
        }

        public String getUserAvatarPath(int userId)
        {
            var loginUser = from x in MainForm.entities.felhasznalok
                            where x.Id == userId
                            select x;
            User user = new User();
            user.SetAttributesFromDB(loginUser.First());

            var userAvatar = from x in MainForm.entities.kepek
                             where x.Id == user.Profile.Avatar
                             select x;
            String avatarPath = null;

            if (userAvatar.Count() > 0)
            {
                avatarPath = Path.Combine(destionationDir, userAvatar.First().utvonal);
            }

            return avatarPath;
        }
    }

    public class GroupHandler : IGroupHandler
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

        public void userHavePermission(int userId)
        {
            var loginUser = from x in MainForm.entities.felhasznalok
                            where x.Id == userId
                            select x;
            User user = new User();
            user.SetAttributesFromDB(loginUser.First());
            
            if (user.GetType().Equals(UserType.GroupUser) || user.GetType().Equals(UserType.Guest))
            {
                throw new PermissionDeniedException("Hozzáférés megtagadva! Csak a group adminnak van joga a csoport adatlapot módosítani!");
            }
        }

        public void saveGroupDatas(int userId)
        {
            try
            {
                this.userHavePermission(userId);
            }
            catch (PermissionDeniedException ex)
            {
                throw ex;
            }
        }
    }

    public class SearchHandler:Interface.ISearchHandler
    {
        public List<Adatkezelő.User> GetUsers(string name, string addr, string bPlace, DateTime birth)
        {
            if (name != null)
                return GetUserByName(name);
            if (addr != null)
                return GetUsersByAddr(addr);
            if (bPlace != null)
                return GetUserByBPlace(bPlace);
            if (birth != DateTime.MinValue)
                return GetUserByBDate(birth);
            else//ha mind1ik null volt, persze ha többnek volt érték adva akkor sorrendben amelyikre először teljesül, ez kicsit fals
                throw new Exception("Hibás User keresési feltételek!");
        }
        public List<Adatkezelő.Event> GetEvent(string name, string place, string desc, DateTime date)
        {
            if (name != null)
                return GetEventsByName(name);
            if (place != null)
                return GetEventsByPlace(place);
            if (desc != null)
                return FindEventsByDesc(desc);
            if (date != DateTime.MinValue)
                return GetEventsByDate(date);
            else
                throw new Exception("Hibás Event keresési felételek!");
        }
        public List<Adatkezelő.Group> GetGroups(string name, string CLname, string addr, DateTime cDate)
        {
            if (name != null)
                return GetGroupsByName(name);
            if (CLname != null)
                return GetGroupsByCLeader(CLname);
            if (addr != null)
                return GetGroupsByAdd(addr);
            if (cDate != DateTime.MinValue)
                return GetGroupsByCreateDate(cDate);
            else
                throw new Exception("Hibás Group keresési feltételek!");
        }
        public List<Adatkezelő.Offer> GetOffers(string name, string sComp, string dComp, DateTime date)
        {
            if (name != null)
                return GetOffersByName(name);
            if (sComp != null)
                return GetOfferBySCompany(sComp);
            if (dComp != null)
                return GetOffersByDestCompany(dComp);
            if (date != DateTime.MinValue)
                return GetOffersByDateTime(date);
            else
                throw new Exception("Hibás Offer keresési feltétlek!");
        }


        private List<User> GetUserByName(string username)
        {//admin, guest nem kell
            var v = from x in MainForm.entities.felhasznalok 
                    where x.nev.Contains(username)&&x.jogosultsagi_szint!=4&&x.jogosultsagi_szint!=1
                    select x;
            List<User> output = new List<User>();
            foreach (var item in v)
            {
                Adatkezelő.User u = new Adatkezelő.User();
                u.SetAttributesFromDB(item);
                output.Add(u);
            }
            return output;
        }
        private List<User> GetUsersByAddr(string addr)
        {//admin, guest nem kell
            List<User> output = new List<User>();
            var v = from x in MainForm.entities.felhasznalok
                    where x.lakhely.Contains(addr) && x.jogosultsagi_szint != 4 && x.jogosultsagi_szint != 1
                    select x;
            foreach (var item in v)
            {
                output.Add(new Adatkezelő.User(item.Id));
            }
            return output;
        }
        private List<User> GetUserByBPlace(string place)
        {//admin, guest nem kell
            List<User> output = new List<User>();
            var v = from x in MainForm.entities.felhasznalok
                    where x.szuletesi_hely.Contains(place) && x.jogosultsagi_szint != 4 && x.jogosultsagi_szint != 1
                    select x;
            foreach (var item in v)
            {
                output.Add(new User(item.Id));
            }
            return output;
        }
        private List<User> GetUserByBDate(DateTime bDate)
        {//admin, guest nem kell
            List<User> output = new List<User>();
            var v = from x in MainForm.entities.felhasznalok
                    where x.szuletesi_ido.Year + x.szuletesi_ido.Month + x.szuletesi_ido.Day == bDate.Year + bDate.Month + bDate.Day && x.jogosultsagi_szint != 4 && x.jogosultsagi_szint != 1//!!!!nem datetime=datetime
                    select x;
            foreach (var item in v)
            {
                User usr = new User();
                usr.SetAttributesFromDB(item);
                output.Add(usr);
            }
            return output;
        }

        private List<Offer> GetOfferBySCompany(string cName)
        {
            //ha tartalmazza a neve a stringet... persze lehetne máshogy is
            List<Offer> output = new List<Offer>();
            var w = from x in MainForm.entities.csoportok
                    where x.cegnev.Contains(cName)
                    select x.Id;
            if (w.Count() != 0)
            {
                var v = from x in MainForm.entities.ajanlatok
                        where w.Contains(x.kezdo_ceg)
                        select x;
                foreach (var item in v)
                {
                    Offer o = new Offer(item);
                    output.Add(o);
                }
            }
            return output;
        }
        private List<Offer> GetOffersByName(string name)
        {
            List<Offer> output = new List<Offer>();
            var v = from x in MainForm.entities.ajanlatok
                    where x.megnevezes.Contains(name)
                    select x;
            foreach (var item in v)
            {
                Offer o = new Offer(item);
                output.Add(o);
            }

            return output;
        }
        private List<Offer> GetOffersByDestCompany(string destC)
        {
            List<Offer> output = new List<Offer>();
            var v = from x in MainForm.entities.csoportok
                    where x.cegnev.Contains(destC)
                    select x.Id;

            if (v.Count() != 0)
            {
                var w = from x in MainForm.entities.ajanlatok
                        where v.Contains(x.fogado_ceg)
                        select x;//megfelelő ajánlatok listája

                foreach (var item in w)
                {//megfelelő ajánlatok=> List<Adatkezelő.Offer>
                    Offer o = new Offer(item);
                    output.Add(o);
                }
            }
            return output;
        }
        private List<Offer> GetOffersByDateTime(DateTime dTime)
        {//kező és végpont közé esik a megadott időpont
            List<Offer> output = new List<Offer>();
            var v = from x in MainForm.entities.ajanlatok
                    where x.kezdes_datum >= dTime && x.zaras_datum != null && x.zaras_datum <= dTime
                    select x;
            foreach (var item in v)
            {
                output.Add(new Offer(item));
            }
            return output;
        }

        private List<Event> GetEventsByName(string eventname)
        { //események melyek neve tartalmazzák az eventname-t
            List<Event> output = new List<Event>();
            var v = from x in MainForm.entities.esemenyek
                    where x.megnevezes.Contains(eventname)
                    select x;
            foreach (var item in v)
            {
                Event ev = new Event();
                ev.Creator = new User(item.letrehozo);
                ev.Date = item.idopont;
                ev.Description = item.leiras;
                ev.Location = item.helyszin;
                ev.Name = item.megnevezes;
                output.Add(ev);
            }
            return output;
        }
        private List<Event> GetEventsByDate(DateTime dateTime)
        {
            List<Event> output = new List<Event>();

            var v = from x in MainForm.entities.esemenyek
                    where x.idopont.Year + x.idopont.Month + x.idopont.Day == dateTime.Year + dateTime.Month + dateTime.Day//!!! óra eltérés miatt
                    select x;
            foreach (var item in v)
            {
                output.Add(new Event(item));
            }
            return output;
        }
        private List<Event> GetEventsByPlace(string place)
        {
            List<Event> output = new List<Event>();
            var v = from x in MainForm.entities.esemenyek
                    where x.helyszin.Contains(place)
                    select x;
            foreach (var item in v)
            {
                output.Add(new Event(item));
            }
            return output;
        }
        private List<Event> FindEventsByDesc(string desc)
        {//leírás alapján
            var v = from x in MainForm.entities.esemenyek
                    where x.leiras.Contains(desc)
                    select x;
            List<Event> output = new List<Event>();
            foreach (var item in v)
            {
                output.Add(new Event(item));
            }
            return output;
        }

        private List<Group> GetGroupsByAdd(string add)
        {//telephely alapján
            List<Group> output = new List<Group>();
            var v = from x in MainForm.entities.csoportok
                    where x.telephely.Contains(add)
                    select x;
            foreach (var item in v)
            {
                Group a = new Group();
                a.SetAttributesFromDB(item);
                output.Add(a);
            }
            return output;
        }
        private List<Group> GetGroupsByDesc(string desc)
        {//leírás alapján keres
            List<Group> output = new List<Group>();
            var v = from x in MainForm.entities.csoportok
                    where x.leiras.Contains(desc)
                    select x;
            foreach (var item in v)
            {
                Group a = new Group();
                a.SetAttributesFromDB(item);
                output.Add(a);
            }
            return output;
        }
        private List<Group> GetGroupsByName(string companyName)
        { //groupok listája amelyek cégneve tartalmazza az átadott stringet
            var v = from x in MainForm.entities.csoportok
                    where x.cegnev.Contains(companyName)
                    select x;
            List<Group> groups = new List<Group>();
            foreach (var item in v)
            {
                Group newgroup = new Group();
                newgroup.SetAttributesFromDB(item);
                groups.Add(newgroup);
            }
            return groups;
        }
        private List<Group> GetGroupsByCLeader(string leaderName)
        {
            List<Group> output = new List<Group>();
            var v = from x in MainForm.entities.csoportok
                    select x.cegvezeto;
            foreach (var item in v)
            {
                if (item != null)//ha volt vezető..nullable..
                {
                    var ve = from x in MainForm.entities.felhasznalok
                             where x.Id == item
                             select x;//azon felhasználók akik főnökök//ebből csak 1lesz
                    if (ve.First() != null)
                    {//létezik a felh
                        var w = from x in MainForm.entities.csoportok
                                where x.cegvezeto == item
                                select x;//fehasználó objektum
                        Group g = new Group();
                        g.SetAttributesFromDB(w.First());
                        output.Add(g);
                    }
                }
            }
            return output;
        }
        private List<Group> GetGroupsByCreateDate(DateTime dTime)
        {//kező és végpont közé esik a megadott időpont
            List<Group> output = new List<Group>();
            var v = from x in MainForm.entities.csoportok
                    where x.alapitas_datuma == dTime//OK?
                    select x;
            foreach (var item in v)
            {
                Group g = new Group();
                g.SetAttributesFromDB(item);
                output.Add(g);
            }
            return output;
        }

    }
}