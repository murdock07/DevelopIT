///////////////////////////////////////////////////////////
//  GroupProfile.cs
//  Implementation of the Class GroupProfile
//  Generated by Enterprise Architect
//  Created on:      08-ápr.-2014 21:23:32
//  Original author: balder
///////////////////////////////////////////////////////////




using Adatkezelő;
namespace Adatkezelő {
	public class GroupProfile : Profile {

		private Group group;
		private String groupAddress;
		private String groupBoss;
		private String groupName;
		private String groupPostAddress;

		public GroupProfile(){

		}

		~GroupProfile(){

		}

		public String getgroupPostAddress(){

			return "";
		}

		public Group group{
			get{
				return group;
			}
			set{
				group = value;
			}
		}

		public String groupAddress{
			get{
				return groupAddress;
			}
			set{
				groupAddress = value;
			}
		}

		public String groupBoss{
			get{
				return groupBoss;
			}
			set{
				groupBoss = value;
			}
		}

		public String groupName{
			get{
				return groupName;
			}
			set{
				groupName = value;
			}
		}

		/// 
		/// <param name="newVal"></param>
		public void setgroupPostAddress(String newVal){

		}

	}//end GroupProfile

}//end namespace Adatkezelő