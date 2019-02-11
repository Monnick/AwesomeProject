using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Interfaces.Classes
{
    class TestReader : Interfaces.ISourceReader
    {
        private readonly string value;

		public void Prepare()
		{
		}

		public void Release()
		{
		}

		public TestReader(string testValue)
        {
            value = testValue;
        }

        public string ReadSource()
        {
            return value;
        }
    }
}
