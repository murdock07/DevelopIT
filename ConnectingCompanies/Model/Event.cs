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
        private string inventedUser;
        private string sortDate;
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
            this.creator = new User(es.letrehozo); //
            this.date = es.idopont;
            this.description = es.leiras;
            this.location = es.helyszin;
            this.name = es.megnevezes;
            this.id = es.Id;
            var v = from x in ConnectingCompanies.MainForm.entities.felhasznalok
                    where x.Id == es.meghivott_szemely
                    select x;
            this.inventedUser = v.First().nev;
            this.sortDate = date.ToString().Substring(date.ToString().IndexOf('.')+1);
            sortDate=sortDate.Substring(0, sortDate.LastIndexOf(':'));
        }
        public override string ToString()
        {
            return  inventedUser+" "+name + " " + location +" "+sortDate+" E#"+id+" C#"+creator.Id;
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