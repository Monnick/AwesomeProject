using Shared.Data;
using Shared.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_ListVsIEnumerable.List
{
	class FindPerson
	{
		public static void Find(string name, Action<Person> OnPersonLoaded)
		{
			PersonSource.Instance.EntityLoaded = OnPersonLoaded;

			var result = PersonSource.Instance.People.ToList().Where(p => p.Name == name).FirstOrDefault();

			PersonSource.Instance.EntityLoaded = null;
		}
	}
}
