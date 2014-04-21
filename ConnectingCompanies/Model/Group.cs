using ConnectingCompanies;
using System.Collections.Generic;
using System.Linq;
using System;

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
            var u = from x in MainForm.entities.felhasznalok
                    where x.Id == cs.cegvezeto
                    select x;
            try
            {
                List<felhasznalok> lista = u.ToList();
                this.groupAdmin = new User();
                groupAdmin.admin = true;
                this.groupAdmin.SetAttributesFromDB(lista[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

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