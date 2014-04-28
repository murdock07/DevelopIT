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
        private String name;
        private String address;
        private DateTime? dateOfFounding;
        private String description;
        private String mailAddress;
        private int? logo;

        private int id;

        public int Id
        {
            get { return id; }
        }

        public Group()
        {
        }
        public override string ToString()
        {
            return name + " " + address + " " + mailAddress;
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

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        public DateTime? DateOfFounding
        {
            get { return dateOfFounding; }
            set { dateOfFounding = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public String MailAddress
        {
            get { return mailAddress; }
            set { mailAddress = value; }
        }

        public int? Logo
        {
            get { return logo; }
            set { logo = value; }
        }

        internal void SetAttributesFromDB(csoportok cs)
        {
            this.id = cs.Id;
            this.Name = cs.cegnev;
            this.Address = cs.telephely;
            this.MailAddress = cs.levelezesi_cim;
            this.DateOfFounding = cs.alapitas_datuma;
            this.Description = cs.leiras;
            this.Logo = cs.logo;

            var ga = from x in MainForm.entities.felhasznalok
                     where x.Id == cs.cegvezeto
                     select x;

            this.GroupAdmin = new User();
            this.GroupAdmin.SetAttributesFromDB(((felhasznalok)ga.First()), false);
        }
    }
}