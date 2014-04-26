using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectingCompanies.Interface
{
    internal interface ILoginHandler
    {
        Session CheckCredentials(string user, string password);
        Form SetUIByUserType(Session cs);
        Session DoRegister(string account, string password, string name, string address, DateTime birthDate);
    }
}
