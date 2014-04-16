using System;
using System.Drawing;

namespace Adatkezelõ {
	public class Profile {

		private Image avatar;
		private String description;

		public Profile(){

		}

		public Image Avatar{
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