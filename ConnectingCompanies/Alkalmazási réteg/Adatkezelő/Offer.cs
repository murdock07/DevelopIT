///////////////////////////////////////////////////////////
//  Offer.cs
//  Implementation of the Class Offer
//  Generated by Enterprise Architect
//  Created on:      08-ápr.-2014 21:23:32
//  Original author: Viktor
///////////////////////////////////////////////////////////




using System;
using Adatkezelő;
namespace Adatkezelő {
	public class Offer {

		private DateTime date;
		private String description;
		private Group destination;
		private String name;
		private Group source;

		public Offer(){

		}

		~Offer(){

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

		public Group destination{
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

		public Group source{
			get{
				return source;
			}
			set{
				source = value;
			}
		}

	}//end Offer

}//end namespace Adatkezelő