using _02_Interfaces.RealWorld.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Interfaces.RealWorld.BusinessLayer
{
	static class BLLogic
	{
		public static BasicScore CalculateScore(int scoreType, BasicScore scoreObject)
		{
			switch (scoreType)
			{
				case ScoreTypes.ReadingScore:
					((ReadingScore)scoreObject).Calculate();
					return scoreObject;
				case ScoreTypes.TypingScore:
					((TypingScore)scoreObject).CalculateScore();
					return scoreObject;
				default:
					return scoreObject;
			}
		}
	}
}
