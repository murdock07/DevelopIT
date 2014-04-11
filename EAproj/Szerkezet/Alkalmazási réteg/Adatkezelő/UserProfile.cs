///////////////////////////////////////////////////////////
//  UserProfile.cs
//  Implementation of the Class UserProfile
//  Generated by Enterprise Architect
//  Created on:      08-ápr.-2014 22:06:21
//  Original author: Viktor
///////////////////////////////////////////////////////////




using Adatkezelő;
namespace Adatkezelő {
	public class UserProfile : Profile {

		private Date birthDate;
		private String birthPlace;
		private String displayName;
		private Group group;
		private String personalAddress;

		public UserProfile(){

		}

		~UserProfile(){

		}

		public Date birthDate{
			get{
				return birthDate;
			}
			set{
				birthDate = value;
			}
		}

		public String birthPlace{
			get{
				return birthPlace;
			}
			set{
				birthPlace = value;
			}
		}

		public String displayName{
			get{
				return displayName;
			}
			set{
				displayName = value;
			}
		}

		public Group group{
			get{
				return group;
			}
			set{
				group = value;
			}
		}

		public String personalAddress{
			get{
				return personalAddress;
			}
			set{
				personalAddress = value;
			}
		}

	}//end UserProfile

}//end namespace Adatkezelő