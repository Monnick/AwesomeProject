using Shared.Data;
using Shared.Source;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _01_ListVsIEnumerable.IEnumerable
{
	class FindPerson
	{
		public static void Find(string name, Action<Person> OnPersonLoaded)
		{
			PersonSource.Instance.EntityLoaded = OnPersonLoaded;

			var result = PersonSource.Instance.People.Where(p => p.Name == name).FirstOrDefault();

			PersonSource.Instance.EntityLoaded = null;
		}
	}
}
