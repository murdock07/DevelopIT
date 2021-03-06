///////////////////////////////////////////////////////////
//  Group.cs
//  Implementation of the Class Group
//  Generated by Enterprise Architect
//  Created on:      08-ápr.-2014 21:23:31
//  Original author: Viktor
///////////////////////////////////////////////////////////




using Adatkezelő;
namespace Adatkezelő {
	public class Group {

		private User groupAdmin;
		private List<GroupEvent> groupEvent;
		private List<Group> groups;
		private List<Offer> offers;
		private List<User> users;
		public GroupEvent m_GroupEvent;
		public Offer m_Offer;
		public GroupProfile m_GroupProfile;

		public Group(){

		}

		~Group(){

		}

		public User groupAdmin{
			get{
				return groupAdmin;
			}
			set{
				groupAdmin = value;
			}
		}

		public List<GroupEvent> groupEvent{
			get{
				return groupEvent;
			}
			set{
				groupEvent = value;
			}
		}

		public List<Group> groups{
			get{
				return groups;
			}
			set{
				groups = value;
			}
		}

		public List<Offer> offers{
			get{
				return offers;
			}
			set{
				offers = value;
			}
		}

		public List<User> users{
			get{
				return users;
			}
			set{
				users = value;
			}
		}

	}//end Group

}//end namespace Adatkezelő