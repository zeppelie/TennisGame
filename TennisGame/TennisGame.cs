namespace TennisGame;

public class TennisGame
{
	private int _player1Score;
	private int _player2Score;

	public void AddPointToPlayerOne()
	{
		_player1Score++;
	}

	public void AddPointToPlayerTwo()
	{
		_player2Score++;
	}

	public string GetScore()
	{
		if (_player1Score >= 4 && _player1Score >= _player2Score + 2)
		{
			return "Player 1 wins the game";
		}

		if (_player2Score >= 4 && _player2Score >= _player1Score + 2)
		{
			return "Player 2 wins the game";
		}

		if (_player1Score >= 3 && _player2Score >= 3)
		{
			if (_player1Score == _player2Score)
			{
				return "Deuce";
			}

			return _player1Score > _player2Score ? "Advantage Player 1" : "Advantage Player 2";
		}
		string[] scoreNames = { "Love", "Fifteen", "Thirty", "Forty" };

		return $"{scoreNames[_player1Score]} - {scoreNames[_player2Score]}";
	}

	public void Player1Scores()
	{
		_player1Score++;
	}


	public void Player2Scores()
	{
		_player2Score++;
	}
}