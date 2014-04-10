using System;

namespace Adatkezelõ {
	public class Offer {

		private DateTime date;
		private String description;
		private Group destination;
		private String name;
		private Group source;

		public Offer(){

		}

		public DateTime Date{
			get{
				return date;
			}
			set{
				date = value;
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

		public Group Destination{
			get{
				return destination;
			}
			set{
				destination = value;
			}
		}

		public String Name{
			get{
				return name;
			}
			set{
				name = value;
			}
		}

		public Group Source{
			get{
				return source;
			}
			set{
				source = value;
			}
		}

	}
}