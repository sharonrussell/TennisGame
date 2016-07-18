namespace TennisGame
{
	public class Game
	{
		public string Score(int score1, int score2){
			return IsDeuce(Add(Convert(score1), Convert(score2)));
		}

		string IsDeuce(string score)
		{
			if (score.Equals("40-40"))
				return "Deuce";

			return score;
		}

		string Convert(int score)
		{
			if (score == 0)
				return ReplaceZero(score);

			return score.ToString();
		}

		string ReplaceZero(int score)
		{
			return score.ToString().Replace("0", "Love");
		}

		string Add(string score1, string score2)
		{
			return $"{score1}-{score2}";
		}
	}
}

