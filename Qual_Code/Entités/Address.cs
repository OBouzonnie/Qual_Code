using System;

namespace Qual_Code.Entités
{
	internal class Address:BaseEntity
	{
		public string city { get; set; }

		public string street { get; set; }

		public int postcode { get; set; }

		public int streetNumber { get; set; }

		public Address(int streetNumber, string street, int postcode, string city)
		{
			this.streetNumber = streetNumber;
			this.street = street;
			this.postcode = postcode;
			this.city = city;
		}
	}
}
