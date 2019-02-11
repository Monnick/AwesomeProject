using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Interfaces.RealWorld.Data
{
	class ReadingScore : BasicScore
	{
		public override int ScoreType => 1;

		public int WordsFinished { get; set; }

		public int TotalWords { get; set; }

		public void Calculate()
		{
			Percentile = WordsFinished / TotalWords;

			Result = Convert.ToInt32(Percentile * 100);
		}
	}
}
