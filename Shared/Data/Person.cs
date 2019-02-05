using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Data
{
	public class Person
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string Street { get; set; }

		public string City { get; set; }

		public string Country { get; set; }
	}
}
