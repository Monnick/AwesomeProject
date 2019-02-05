using System;

namespace _01_ListVsIEnumerable
{
	class Program
	{
		static void Main(string[] args)
		{
			const string NAME = "Duke Twinborne";

			int entitiesLoadedByList = 0;
			int entitiesLoadedByIEnumerable = 0;

			List.FindPerson.Find(NAME, p => entitiesLoadedByList++);

			Console.WriteLine("Entities loaded with list: " + entitiesLoadedByList);

			IEnumerable.FindPerson.Find(NAME, p => entitiesLoadedByIEnumerable++);

			Console.WriteLine("Entities loaded with ienumerable: " + entitiesLoadedByIEnumerable);

			Console.WriteLine("Run real world example...");

			RealWorld.Program.Main(NAME, Console.WriteLine);
		}
	}
}
