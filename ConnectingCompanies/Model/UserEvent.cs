using System;
using System.Collections.Generic;

namespace Adatkezelõ {
	public class UserEvent : Event {

		private User user;
		private List<User> users;

		public UserEvent(){

		}

		public User User{
			get{
				return user;
			}
			set{
				user = value;
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