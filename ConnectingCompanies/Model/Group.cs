using ConnectingCompanies;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Adatkezelõ
{
    public class Group
    {

        private User groupAdmin;
        private List<GroupEvent> groupEvent;
        private List<Offer> offers;
        public GroupProfile groupProfile;

        public Group()
        {

        }

        public User GroupAdmin
        {
            get { return groupAdmin; }
            set { groupAdmin = value; }
        }
        public List<GroupEvent> GEvent
        {
            get { return groupEvent; }
            set { groupEvent = value; }
        }
        public List<Offer> Offers
        {
            get { return offers; }
            set { offers = value; }
        }

        internal void SetAttributesFromDB(csoportok cs)
        {
            //TODO: get csoportadatok + set attr
            var u = from x in MainForm.entities.felhasznalok
                     where x.Id == (int)cs.cegvezeto
                     select x;

            this.groupAdmin = new User();
            this.groupAdmin.SetAttributesFromDB((felhasznalok)u);

            this.groupProfile = new GroupProfile();
            this.groupProfile.SetAttributesFromDB(cs);

            var ev = from x in MainForm.entities.esemenyek
                     where x.csoportos == true && x.letrehozo == cs.cegvezeto
                     select x;

            if (ev.Count() > 0)
            {
                this.groupEvent = new List<GroupEvent>();
                foreach (esemenyek ge in ev)
                {
                    GroupEvent ne = new GroupEvent();
                    ne.SetAttributesFromDB(ge);
                    groupEvent.Add(ne);
                } 
            }            
        }
    }
}