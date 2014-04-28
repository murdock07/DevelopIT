using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adatkezelő;

namespace ConnectingCompanies.Interface
{
    interface IAddEventHandler
    {
        List<Adatkezelő.Event> GetPersonalEvents(User us);
        List<Adatkezelő.GroupEvent> GetGroupEvents(User us);
        List<Adatkezelő.User> GetAllUsers();
        void CreateEvent(User creator, bool group, string name, string desc, string place, DateTime time, List<User> invited);
        void DeleteEvent(Event ev);
        void ModifyEventsGroup(User us, Event modEv, string name, string description, string place, DateTime dTime);
        void ModifyPersonalEvent(User us, Event modEv, string name, string description, string place, DateTime dTime);
    }
}
