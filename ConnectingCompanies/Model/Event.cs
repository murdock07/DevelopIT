using System;
using System.Collections.Generic;
using System.Linq;

namespace Adatkezelõ
{
    public class Event
    {
        private User creator;
        private DateTime date;
        private String description;
        private String location;
        private String name;

        //public Event(ConnectingCompanies.esemenyek es, User creator)
        //{
        //    this.creator = creator;
        //    this.date = es.idopont;
        //    this.description = es.leiras;
        //    this.location = es.helyszin;
        //    this.name = es.megnevezes;
        //}
        public Event()
        {
        }

        public Event CreatNewEvent()
        {
            return new Event();
        }

        //public static List<Event> GetMyEvents(User user)//listBoxPersonalEvents
        //{//visszaadja a felhasználó által létrehozott események listáját
        //    ConnectingCompanies.nyilvantartasEntities entities = new ConnectingCompanies.nyilvantartasEntities();
        //    var v = from x in entities.esemenyek
        //            where x.letrehozo == user.Id
        //            select x;
        //    List<Event> output = new List<Event>();
        //    foreach (var item in v)
        //    {
        //        Event ev = new Event(item,user);
        //        output.Add(ev);
        //    }
        //    return output;
        //}
        //public static List<Event> GetGroupEvents(Group gr)//listBoxGroupEvents
        //{//visszaadja azon események listáját mely kapcsolatos a megadott csoporttal/csoport IDvel
        //    ConnectingCompanies.nyilvantartasEntities entities = new ConnectingCompanies.nyilvantartasEntities();
        //    var v = from x in entities.esemenyek
        //            where x.csoportok.Id == gr.Id
        //            select x;
        //    List<Event> output = new List<Event>();
        //    foreach (var item in v)
        //    {
        //        var ve = from x in entities.esemenyek
        //                 where x.Equals(item)
        //                 select x.letrehozo;
        //        output.Add(new Event((item as ConnectingCompanies.esemenyek), new User(ve.First())));
        //    }

        //    return  output;
        //}
        public User Creator
        {
            get { return creator; }
            set { creator = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public String Location
        {
            get { return location; }
            set { location = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}