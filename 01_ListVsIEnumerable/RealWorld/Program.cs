using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ListVsIEnumerable.RealWorld
{
	class Program
	{
		public static void Main(string name, Action<string> output)
		{
			var match = LogicFunctions.FindByName(name);

			if (match.Count == 1)
				output("person (" + name + ") found exactly once!");
			else
				output("person not found.");
		}
	}
}
