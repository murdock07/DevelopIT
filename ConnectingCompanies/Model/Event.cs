using System;
using System.Collections.Generic;
using System.Linq;

namespace Adatkezel�
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

        public Event(ConnectingCompanies.esemenyek es)
        {//letrej�n a gener�lt esem�ny objektum �ltal az adatkezel� objektum
            this.creator = new User(es.letrehozo); //
            this.date = es.idopont;
            this.description = es.leiras;
            this.location = es.helyszin;
            this.name = es.megnevezes;
        }

        public Event CreatNewEvent()
        {
            return new Event();
        }

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