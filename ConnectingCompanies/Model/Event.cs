using System;

namespace Adatkezelõ
{
    public class Event
    {
        private User creator;
        private DateTime date;
        private String description;
        private String location;
        private String name;

        public Event()
        {

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