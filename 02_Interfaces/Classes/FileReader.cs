using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Interfaces.Classes
{
    class FileReader : Interfaces.ISourceReader
	{
		private readonly string content;

		public void Prepare()
		{
		}

		public void Release()
		{
		}

        public FileReader(string fileName)
        {
            content = System.IO.File.ReadAllText(fileName);
        }

        public string ReadSource()
        {
            return content;
        }
    }
}
