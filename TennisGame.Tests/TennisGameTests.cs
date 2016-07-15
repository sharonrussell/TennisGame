using NUnit.Framework;

namespace TennisGame.Tests
{
	[TestFixture]
	public class TennisGameTests
	{
		[TestCase(15, 0, "15-Love")]
		[TestCase(0, 0, "Love-Love")]
		[TestCase(40, 40, "Deuce")]
		[TestCase(15, 30, "15-30")]
		public void ShouldOutputCorrectScore(int score1, int score2, string result){
			var game = new Game();

			Assert.That(game.Score(score1, score2), Is.EqualTo(result));
		}
	}
}