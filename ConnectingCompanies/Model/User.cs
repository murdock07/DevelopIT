using System;
using System.Collections.Generic;

namespace Adatkezelő {
	public class User {

		private Group group;
		private String password;
		private UserProfile profile;
		private UserType type;
		private List<UserEvent> userEvents;
        private String userName;
		public Group m_Group;
		public Message m_Message;

		public User(){

		}

		public Group Group{
			get{
				return group;
			}
			set{
				group = value;
			}
		}

		public String Password{
			get{
				return password;
			}
			set{
				password = value;
			}
		}

		public UserProfile Profile{
			get{
				return profile;
			}
			set{
				profile = value;
			}
		}

		public UserType Type{
			get{
				return type;
			}
			set{
				type = value;
			}
		}

		public List<UserEvent> UserEvents{
			get{
				return userEvents;
			}
			set{
				userEvents = value;
			}
		}

		public String UserName{
			get{
				return userName;
			}
			set{
				userName = value;
			}
		}

	}
}