using Shared.Data;
using Shared.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_ListVsIEnumerable.RealWorld
{
	// e.g. created by entity framework
	class DbContext
	{
		public static IEnumerable<Person> People => PersonSource.Instance.People;
	}
}
