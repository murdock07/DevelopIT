using Adatkezelő;
using ConnectingCompanies.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectingCompanies.Controller
{
    class LoginHandler
    {
        internal static Session CheckCredentials(string user, string password)
        {
            var loginUser = from x in MainForm.entities.felhasznalok
                            where x.azonosito == user
                            select x;
            List<felhasznalok> lista = loginUser.ToList();
            if (lista.Count < 1)
            {
                throw new UserNotExistsException(user);
            }
            else
            {
                User currentUser = new User();
                currentUser.admin = false;
                currentUser.SetAttributesFromDB(lista[0]);
                string pwd = currentUser.Password.Trim();
                if (!pwd.Equals(password))
                {
                    throw new PasswordMismatchException(password);
                }
                else
                {
                    return new Session(currentUser);
                }
            }
        }

        internal static Form SetUIByUserType(Session cs)
        {            
            UserInterfaceForm UIF = new UserInterfaceForm(cs);

            var c = UIF.Controls.Find("tabControlUserInterface", true).ToList();
            TabControl tc = (TabControl)c[0];
            List<TabPage> tabPages = new List<TabPage>();
            foreach (TabPage page in tc.TabPages)
            {
                tabPages.Add(page);
            }

            //user type alapján jogosultság belövés
            if (cs.CurrentUser.Type == UserType.SysAdmin)
            {
                tc.TabPages.Remove(tabPages[0]);    //profil
                tc.TabPages.Remove(tabPages[1]);    //csoport
                tc.TabPages.Remove(tabPages[2]);    //naptár
                //tc.TabPages.Remove(tabPages[3]);  //kereső
                //tc.TabPages.Remove(tabPages[4]);    //admin
            }
            else if (cs.CurrentUser.Type == UserType.Guest)
            {
                tc.TabPages.Remove(tabPages[0]);    //profil
                tc.TabPages.Remove(tabPages[1]);    //csoport
                tc.TabPages.Remove(tabPages[2]);    //naptár
                //tc.TabPages.Remove(tabPages[3]);  //kereső
                tc.TabPages.Remove(tabPages[4]);    //admin
            }
            else
            {
                //tc.TabPages.Remove(tabPages[0]);    //profil
                //tc.TabPages.Remove(tabPages[1]);    //csoport
                //tc.TabPages.Remove(tabPages[2]);    //naptár
                //tc.TabPages.Remove(tabPages[3]);  //kereső
                tc.TabPages.Remove(tabPages[4]);    //admin
            }
            return UIF;
        }

        internal static Session DoRegister(string account, string password, string name, string address, DateTime birthDate)
        {
            //1.  -  ellenőrizni, hogy foglalt-e a felhasználó azonosító
            var usr = from x in MainForm.entities.felhasznalok
                      where x.azonosito == account
                      select x;
            //1a. -  ha foglalt akkor-> exception
            //1b. -  ha szabad, akkor továbblépés a felhasználó mentéséhez
            if (usr.Count() > 0)
            {
                throw new UserExistsException(account);
            }
            else
            {
                //2.  -  felhaszáló összeállítása
                //3.  -  felhasználó mentése adatbázisba
                felhasznalok flhsznl = new felhasznalok();
                flhsznl.Id = MainForm.entities.felhasznalok.Count() + 1;
                flhsznl.azonosito = account;
                flhsznl.jelszo = password;
                flhsznl.jogosultsagi_szint = 1;
                flhsznl.nev = name;
                flhsznl.szuletesi_ido = birthDate;
                flhsznl.lakhely = address;

                MainForm.entities.felhasznalok.Add(flhsznl);
                MainForm.entities.SaveChanges();

                User currentUser = new User();
                currentUser.SetAttributesFromDB(flhsznl);
                return new Session(currentUser);
            }           
        }
    }
}
