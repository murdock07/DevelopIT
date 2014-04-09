using System;
using System.Collections.Generic;

namespace Adatkezelõ {
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

		public User GroupAdmin{
			get{
				return groupAdmin;
			}
			set{
				groupAdmin = value;
			}
		}

		public List<GroupEvent> GroupEvent{
			get{
				return groupEvent;
			}
			set{
				groupEvent = value;
			}
		}

		public List<Group> Groups{
			get{
				return groups;
			}
			set{
				groups = value;
			}
		}

		public List<Offer> Offers{
			get{
				return offers;
			}
			set{
				offers = value;
			}
		}

		public List<User> Users{
			get{
				return users;
			}
			set{
				users = value;
			}
		}

	}
}