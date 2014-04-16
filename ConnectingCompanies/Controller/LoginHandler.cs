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
            if (lista.Count == null)
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
    }
}
