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
        private int id;

        public int Id
        {
            get { return id; }
            //set { id = value; }
        }

        public Event()
        {
        }

        public Event(ConnectingCompanies.esemenyek es)
        {
            //letrejön a generált esemény objektum által az adatkezelõ objektum
            this.creator = new User(es.letrehozo); //
            this.date = es.idopont;
            this.description = es.leiras;
            this.location = es.helyszin;
            this.name = es.megnevezes;
            this.id = es.Id;
        }
        public override string ToString()
        {
            return  this.name + " " + this.location +" "+this.date.ToString()+" E#"+this.id+" C#"+this.creator.Id;
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