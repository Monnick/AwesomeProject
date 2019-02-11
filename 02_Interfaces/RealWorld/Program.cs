using _02_Interfaces.RealWorld.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Interfaces.RealWorld
{
	class Program
	{
		public static void Main(int scoretype)
		{
			BasicScore score = null;

			if (scoretype == ScoreTypes.ReadingScore)
				score = new ReadingScore() { TotalWords = 8081, WordsFinished = 42 };
			else if (scoretype == ScoreTypes.TypingScore)
				score = new TypingScore() { TypedWords = 4223, CorrectWords = 235, WrongWords = 2019 };
			else
				return;

			// calculcate Score
			BusinessLayer.BLLogic.CalculateScore(scoretype, score);
		}
	}
}
