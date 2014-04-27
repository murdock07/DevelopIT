using System;
using System.Drawing;

namespace Adatkezelő {
	public class Profile {

		private int? avatar;
		private String description;

		public Profile(){

		}

		public int? Avatar{
			get{
				return avatar;
			}
			set{
				avatar = value;
			}
		}

		public String Description{
			get{
				return description;
			}
			set{
				description = value;
			}
		}

	}
}