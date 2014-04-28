using ConnectingCompanies.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectingCompanies.Controller
{
    /**/

    internal class AddEventHandler : IAddEventHandler
    {
        //MainForm.entities !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //private nyilvantartasEntities entities = new nyilvantartasEntities();

        public List<Adatkezelő.Event> GetPersonalEvents(Adatkezelő.User us)
        {//visszaadja azokat az adatkezelő.event-eket melyek létrehozója a megadott user
            var v = from x in MainForm.entities.esemenyek
                    where x.letrehozo == us.Id
                    select x;   //van egy listánk ami tárolja azokat az eseményeket amelyeket a felhasználó hozott létre
            List<Adatkezelő.Event> output = new List<Adatkezelő.Event>();//ez fogja visszadni az adatkezelő.event objektumokat a viewnak
            if (v != null)
            {
                foreach (var item in v)
                {
                    output.Add(new Adatkezelő.Event(item as esemenyek));
                }
            }
            return output;//b+..
        }

        //azon eseményeket adja vissza melyek meghívott csoportjának azonosítóját tartalmazza a felhasználó csoportjainak listája
        //kikeressük az Adatkezelő.User hez tartotó felhasznalok db objektumot
        //kikeressük azon csoportok db elemeket helyek felhasznalok listájában szerepel a megadott felhasználó
        //események táblából kiválasztjuk azokat melyeknél a kiválasztott csoport megtalálható a felhasználónk csoportjainak listájában
        public List<Adatkezelő.GroupEvent> GetGroupEvents(Adatkezelő.User us)
        {
            var f = from x in MainForm.entities.felhasznalok
                    where x.Id == us.Id
                    select x; // most megvan a felhasználónak megfelelő geneált db objektum;

            var ve = from x in MainForm.entities.csoportok
                     where x.felhasznalok1.Contains(f.First())
                     select x; //most megvannak azok a generált generált db csoport objektumok melyeknek tagja a felhasználó

            var v = from x in MainForm.entities.esemenyek//végigmegyünk az eseményken, ha csoportos és a felhasználó csoportjai között szerepel az a csoport amit meghívtak akkor jó
                    where x.csoportos == true && ve.ToList().Contains(x.csoportok)
                    select x;   //megvannak azok a generált esemény objektumok amelyek
            //System.Windows.Forms.MessageBox.Show(v.ToString());
            List<Adatkezelő.GroupEvent> output = new List<Adatkezelő.GroupEvent>();
            //TODO: viktor ez mi?
            #region
            //if (v != null)
            //{
            //    foreach (var item in v.ToList())
            //    {
            //        Adatkezelő.GroupEvent ad=new Adatkezelő.GroupEvent();
            //        ad.SetAttributesFromDB(item);
            //        //ad.Groups=//
            //        output.Add(ad);
            //    }//
            //}
            #endregion
            return output;//események melynek meghívott csoportjai között szerepel a felhasználó valamely csoportja
        }

        //összes usert visszaadja //kivéve adminokat
        public List<Adatkezelő.User> GetAllUsers()
        {
            var v = from x in MainForm.entities.felhasznalok
                    where x.jogosultsagi_szint != 4 && x.jogosultsagi_szint != 1//nem admin és nem vendég
                    select x;       //csak a felhasználókat listázza ki nem kell az admin is
            List<Adatkezelő.User> output = new List<Adatkezelő.User>();
            if (v != null)
            {
                foreach (var item in v)
                {
                    var ve = from x in MainForm.entities.felhasznalok
                             where x.Id == item.Id
                             select x;
                    Adatkezelő.User usr = new Adatkezelő.User();
                    usr.SetAttributesFromDB(ve.First());
                    output.Add(usr);
                }
            }
            return output;
        }

        //ha group igaz akkor meghívja a saját csoportjának az összes emberét?
        //dokumentációban az volt, hogy a felhasználó, csak a saját csoportjában tud eseményt létrehozni
        //"dolgozók is tudnak eseményeket szervezni, viszont ők csak a csoporton belül."
        public void CreateEvent(Adatkezelő.User creator, bool group, string name, string desc, string place, DateTime time, List<Adatkezelő.User> invited)
        {
            if (group)//ha csoportos        //erről volt szó
            {
                esemenyek e = new esemenyek();
                e.csoportos = true;
                e.aktiv = true;
                e.helyszin = place;
                e.Id = CreateNewEventId();
                e.idopont = time;
                e.leiras = desc;
                e.letrehozo = creator.Id;
                if (creator.Group == null)//nincs csoportja a felhasználónak
                    throw new Exception("A felhasználónak nincs csoportja!");
                e.meghivott_csoport = creator.Group.Id;//creator.goup ==nullreference..
                e.megnevezes = name;
                MainForm.entities.esemenyek.Add(e);
                MainForm.entities.SaveChanges();
            }
            else//ha egyéni//létrehozunk annyi eseményt ahány emberünk van......
            {
                for (int i = 0; i < invited.Count; i++)
                {   //miért nincs egy táblánk ami tartalmazza az esemény azonosítókat és a userid-ket mellé...
                    esemenyek e = new esemenyek();//egy ember akar egy találkát, meghív 15 embert, 15 rekordban tároljuk ezeket az eseményeket
                    e.aktiv = true;                 //mindegyik eseménynek külön id-je lesz, szal az alapján nem lehet azonosítani
                    e.csoportos = false;            //ha módosítani akarja egy már létrehozott eseményét akkor
                    e.helyszin = place;             //végig kell menni az összes rekordon megnézni h ő csinálta-e illetve h ez az az esemény e amire gondolt
                    e.idopont = time;
                    e.leiras = desc;
                    e.letrehozo = creator.Id;
                    e.meghivott_szemely = invited[i].Id;
                    e.megnevezes = name;
                    e.Id = CreateNewEventId();
                    MainForm.entities.esemenyek.Add(e);//hozzáadás lefut
                    MainForm.entities.SaveChanges();//hiba történt a bejegyzések firssítése közben Dbexception?!
                }
            }
        }

        private int CreateNewEventId()
        {
            var v = from x in MainForm.entities.esemenyek
                    select x.Id;

            if (v != null && v.Count() > 0)
                return v.Max() + 1;
            else
                return 1;
        }

        public void DeleteEvent(Adatkezelő.Event ev)
        {
            var v = from x in MainForm.entities.esemenyek
                    where x.Id == ev.Id
                    select x;

            MainForm.entities.esemenyek.Remove(v.First());
            MainForm.entities.SaveChanges();
        }

        public void ModifyEventsGroup(Adatkezelő.User us, string name, string description, string place, DateTime dTime)
        {//tfh hogy ha a csoportos van kiválasztva akkor az események közül azt választjuk ki amelyiknek ő a létrehozója és csoportos
            //ennek az adatait módosítjuk
            var v = from x in MainForm.entities.esemenyek
                    where x.letrehozo == us.Id && x.csoportos == true
                    select x;
            if (v.Count() != 0)
            {
                (v as List<esemenyek>)[0].helyszin = place;
                (v as List<esemenyek>)[0].leiras = description;
                (v as List<esemenyek>)[0].megnevezes = name;
                (v as List<esemenyek>)[0].idopont = dTime;
                MainForm.entities.SaveChanges();//?
            }
        }
    }
}