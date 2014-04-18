using Adatkezelő;
using System;
using System.Collections.Generic;
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
                currentUser.SetAttributesFromDB(lista[0]);
                if (currentUser.Password.Equals(password))
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
            //TODO: UI felépítése típus szerint
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
    }
}
