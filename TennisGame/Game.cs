namespace TennisGame
{
	public class Game
	{
		public string Score(int score1, int score2){
			return IsDeuce(Add(Convert(score1), Convert(score2)));
		}

		private string IsDeuce(string score){
			if (score.Equals("40-40"))
				return "Deuce";

			return score;
		}

		private string Convert(int score)
		{
			return score.ToString().Replace("0", "Love");
		}

		private string Add(string score1, string score2)
		{
			return score1 + "-" + score2;
		}
	}
}

