using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Interfaces.RealWorld.Data
{
	class TypingScore : BasicScore
	{
		public override int ScoreType => 2;

		public int TypedWords { get; set; }

		public int CorrectWords { get; set; }

		public int WrongWords { get; set; }

		public void CalculateScore()
		{
			Percentile = CorrectWords / TypedWords;

			Result = CorrectWords - WrongWords;
		}
	}
}
