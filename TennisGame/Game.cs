using System.Collections.Generic;

namespace TennisGame
{
	public class Game
	{
		Dictionary<int, string> scores = new Dictionary<int, string>{
			{0, "Love"},
			{15, "15"},
			{30, "30"},
			{40, "40"}
		};

		public string Score(int score1, int score2){
			var score = $"{scores[score1]}-{scores[score2]}";
			return score.Replace("40-40", "Deuce");
		}
	}
}

