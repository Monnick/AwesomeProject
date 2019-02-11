using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Interfaces.Classes
{
    class ConsoleReader : Interfaces.ISourceReader
    {
		public void Prepare()
		{
		}

		public void Release()
		{
		}

		public string ReadSource()
        {
            return Console.ReadLine();
        }
	}
}
