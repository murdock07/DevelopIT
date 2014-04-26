using System;
using System.Linq;
namespace Adatkezel�
{
    public class Offer
    {

        private DateTime date;
        private String description;
        private Group destination;
        private String name;
        private Group source;

        public Offer()
        {

        }
        public Offer(ConnectingCompanies.nyilvantartasEntities entities, ConnectingCompanies.ajanlatok off)
        {
            this.date = off.kezdes_datum;
            this.description = off.leiras;
            this.name = off.megnevezes;

            var v = from x in entities.csoportok
                    where x.Id ==off.kezdo_ceg
                    select x;
            Adatkezel�.Group sourceGroup = new Adatkezel�.Group();
            sourceGroup.SetAttributesFromDB(v.First());
            this.source = sourceGroup;

            var w = from x in entities.csoportok
                    where x.Id == off.fogado_ceg
                    select x;
            Adatkezel�.Group destGroup = new Adatkezel�.Group();
            destGroup.SetAttributesFromDB(v.First());
            this.destination = destGroup;
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
        public Group Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public Group Source
        {
            get { return source; }
            set { source = value; }
        }
    }
}