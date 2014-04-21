using ConnectingCompanies;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Adatkezelõ
{
    public class GroupEvent : Event
    {
        private Group group;
        private List<Group> groups;

        public GroupEvent()
        {
        }

        public Group Group
        {
            get { return group; }
            set { group = value; }
        }

        public List<Group> Groups
        {
            get { return groups; }
            set { groups = value; }
        }

        internal void SetAttributesFromDB(ConnectingCompanies.esemenyek ge)
        {
            var letrehozo = from x in MainForm.entities.felhasznalok
                            where x.Id == ge.letrehozo
                            select x;
            this.Creator = new User();
            this.Creator.SetAttributesFromDB(letrehozo.ToList()[0]);
            this.Date = ge.idopont;
            this.Description = ge.leiras;
            this.Location = ge.helyszin;
            this.Name = ge.megnevezes;
            //this.group
            var g = from x in MainForm.entities.csoportok
                    where x.cegvezeto == ge.letrehozo
                    select x;

            this.group = new Group();
            this.group.SetAttributesFromDB(g.ToList()[0]);
            //this.groups ---> meghvott csoportok
            //TODO: minden ide illõ csoport beszedése
        }
    }
}