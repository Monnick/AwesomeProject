using Shared.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_ListVsIEnumerable.RealWorld
{
	class LogicFunctions
	{
		public static List<Person> FindByName(string name)
		{
			var people = DbContext.People.ToList();

			return people.Where(p => p.Name == name).ToList();
		}
	}
}
