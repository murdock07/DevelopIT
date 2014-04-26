using ConnectingCompanies;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Adatkezel�
{
    public class User
    {

        private Group group;
        private String password;
        private UserProfile profile;
        private UserType type;
        private List<UserEvent> userEvents;
        private String userName;
        public Group m_Group;
        public Message m_Message;
        private int id;
        private String rank;

        public String Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        public override string ToString()//na itt viszont csak egy group van.. nem egy lsita..?
        {
            return this.userName + " " + this.profile.PersonalAddress;
        }
        public int Id
        {
            get { return id; }
            //set { id = value; }
        }
        public User()
        {

        }
        public User(int userId)
        {
      
 
        }
        public Group Group
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
            }
        }

        public String Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public UserProfile Profile
        {
            get
            {
                return profile;
            }
            set
            {
                profile = value;
            }
        }

        public UserType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public List<UserEvent> UserEvents
        {
            get
            {
                return userEvents;
            }
            set
            {
                userEvents = value;
            }
        }

        public String UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public void SetAttributesFromDB(felhasznalok felhasznalo)
        {
            //csoport kiv�laszt�sa a felhaszn�l�hoz
            if (!admin)
            {
                if (felhasznalo.csoport != null)
                {
                    var cs = from x in MainForm.entities.csoportok
                             where x.Id == (int)felhasznalo.csoport
                             select x;

                    this.group = new Group();
                    this.Group.SetAttributesFromDB((csoportok)(cs.First()));
                }
                else
                {
                    this.group = null;
                }
            }
            //jelsz�
            this.password = felhasznalo.jelszo;
            //felhaszn�l�s t�pus meghat�roz�sa
            this.type = (UserType)Enum.GetValues(typeof(UserType)).GetValue(felhasznalo.jogosultsagi_szint - 1);
            //azonos�t�
            this.userName = felhasznalo.azonosito;
            this.rank = felhasznalo.beosztas;
            this.id = felhasznalo.Id;
            this.profile = new UserProfile();
            this.profile.SetAttributesFromDB(felhasznalo);
        }

        public bool admin { get; set; }
    }
}