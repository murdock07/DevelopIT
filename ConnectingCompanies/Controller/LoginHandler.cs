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
        internal static void DoLogin(string user, string password)
        {
            try
            {
                adatbazisEntities entities = new adatbazisEntities();

                var emberek = from x in entities.felhasznalok
                              select x;
                var csoportok = from x in entities.csoportok
                                select x;

                string emeberString = "";
                foreach (var item in emberek)
                {
                    emeberString += (item + "\n");
                }

                string csoportString = "";
                foreach (var item in emberek)
                {
                    csoportString += (item + "\n");
                }

                MessageBox.Show("felhasználók:\n" + emeberString + "\ncsoportok:\n" + csoportString);
            }
            catch (Exception ex)
            {
                string currentUser = Environment.UserName;
                new Logger(ex,currentUser,DateTime.Now);
            }
        }
    }
}
