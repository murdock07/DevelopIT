using System;

namespace Adatkezelõ {
	public class UserProfile : Profile {

		private DateTime birthDate;
		private String birthPlace;
		private String displayName;
		private Group group;
		private String personalAddress;

		public UserProfile(){

		}

		public DateTime BirthDate{
			get{
				return birthDate;
			}
			set{
				birthDate = value;
			}
		}

		public String BirthPlace{
			get{
				return birthPlace;
			}
			set{
				birthPlace = value;
			}
		}

		public String DisplayName{
			get{
				return displayName;
			}
			set{
				displayName = value;
			}
		}

		public Group Group{
			get{
				return group;
			}
			set{
				group = value;
			}
		}

		public String PersonalAddress{
			get{
				return personalAddress;
			}
			set{
				personalAddress = value;
			}
		}


        internal void SetAttributesFromDB(ConnectingCompanies.felhasznalok felhasznalo)
        {
            this.birthDate = felhasznalo.szuletesi_ido;
            this.birthPlace = felhasznalo.szuletesi_hely;
            this.displayName = felhasznalo.nev;
            this.Description = felhasznalo.leiras;
            //TODO: kép betöltése útvonal alapján
            //this.Avatar = felhasznalo.profilkep;
            this.personalAddress = felhasznalo.lakhely;
        }
    }
}