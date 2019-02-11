using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Interfaces.RealWorld.Data
{
	class BasicScore
	{
		public virtual int ScoreType { get; }

		public int Result { get; set; }

		public double Percentile { get; set; }

		public DateTime CreatedAt { get; set; }

		public TimeSpan Duration { get; set; }
	}
}
