using System;

namespace _02_Interfaces
{
	class Program
	{
		const string DATA_SOURCE = ".\\Ressources\\storage_person.json";

		static void Main(string[] args)
		{
			Console.WriteLine("Example: Interfaces");
			
			// read hard coded from a json source.
			ReadHardCodedSource();

			// read from a dynamic source
			ReadDynamicSource(Data.SourceType.File);

			// read from a source hidden by interface
			Interfaces.ISourceReader reader = SelectSource(Data.SourceType.File, DATA_SOURCE);

			string content = ReadFromSource(reader);
		}

		private static void ReadHardCodedSource()
		{
			Classes.FileReader reader = new Classes.FileReader(DATA_SOURCE);

			reader.Prepare();

			string content = reader.ReadSource();

			reader.Release();
		}

		private static void ReadDynamicSource(Data.SourceType selectedSource)
		{
			string sourceContent = string.Empty;
			if (selectedSource == Data.SourceType.Console)
			{
				var console = new Classes.ConsoleReader();

				console.Prepare();

				sourceContent = console.ReadSource();

				console.Release();
			}
			else if (selectedSource == Data.SourceType.File)
			{
				var filesource = new Classes.FileReader(DATA_SOURCE);

				filesource.Prepare();

				sourceContent = filesource.ReadSource();

				filesource.Release();
			}
			else if (selectedSource == Data.SourceType.Input)
			{
				var inputsource = new Classes.TestReader(DATA_SOURCE);

				inputsource.Prepare();

				sourceContent = inputsource.ReadSource();

				inputsource.Release();
			}
		}

		private static Interfaces.ISourceReader SelectSource(Data.SourceType sourceType, string source)
		{
			if (sourceType == Data.SourceType.Console)
				return new Classes.ConsoleReader();
			else if (sourceType == Data.SourceType.File)
				return new Classes.FileReader(source);
			else if(sourceType == Data.SourceType.Input)
				return new Classes.TestReader(source);
			return null;
		}

		private static string ReadFromSource(Interfaces.ISourceReader reader)
		{
			reader.Prepare();

			string content = reader.ReadSource();

			reader.Release();

			return content;
		}
	}
}
