using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Interfaces.Interfaces
{
    interface ISourceReader
    {
		void Prepare();

        string ReadSource();

		void Release();
    }
}
