using Adatkezelő;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectingCompanies.Controller
{
    class LoginHandlerException : Exception
    {
        string uzenet;
        public string Uzenet { get { return uzenet; } }

        public LoginHandlerException(string message)
            : base("Hibatörtént a bejelentkezéskor!")
        {
            uzenet = "Hibatörtént a bejelentkezéskor: " + message;
        }
    }

    class UserNotExistsException : LoginHandlerException
    {
        string user;
        public string User { get { return user; } }

        public UserNotExistsException(string user)
            : base(String.Format("A(z) '{0}' nevű felhasználó nem létezik.", user))
        {
            this.user = user;
        }
    }

    class PasswordMismatchException : LoginHandlerException
    {
        string password;
        public string Password { get { return password; } }

        public PasswordMismatchException(string password)
            : base("Rossz jelszót adott meg!")
        {
            this.password = password;
        }
    }

    class UserExistsException : LoginHandlerException
    {
        string user;
        public string User
        {
            get { return user; }
        }

        public UserExistsException(string user)
            : base("Az adott felhasználó már létezik!")
        {
            this.user = user;
        }
    }
}
