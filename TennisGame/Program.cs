namespace TennisGame;

internal class Program
{
	private static void Main()
	{
		var game = new TennisGame();

		game.Player1Scores();
		game.Player1Scores();
		game.Player2Scores();
		game.Player2Scores();
		game.Player1Scores();
		game.Player2Scores();
		game.Player1Scores();

		Console.WriteLine("Final Score: " + game.GetScore());
	}
}