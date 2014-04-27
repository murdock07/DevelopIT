using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectingCompanies.Interface
{
        interface ISearchHandler
        {
            List<Adatkezelő.Offer> GetOffers(string name, string sComp, string dComp, DateTime date);
            List<Adatkezelő.Group> GetGroups(string name, string CLname, string addr, DateTime cDate);
            List<Adatkezelő.Event> GetEvent(string name, string place, string desc, DateTime date);
            List<Adatkezelő.User> GetUsers(string name, string addr, string bPlace, DateTime birth);
        }
    
}
