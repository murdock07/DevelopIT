using ConnectingCompanies;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Adatkezelõ
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

        public User()
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
            //csoport kiválasztása a felhasználóhoz
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
            //jelszó
            this.password = felhasznalo.jelszo;
            //felhasználós típus meghatározása
            this.type = (UserType)Enum.GetValues(typeof(UserType)).GetValue(felhasznalo.jogosultsagi_szint - 1);
            //azonosító
            this.userName = felhasznalo.azonosito;
            this.profile = new UserProfile();
            this.profile.SetAttributesFromDB(felhasznalo);
        }

        public bool admin { get; set; }
    }
}