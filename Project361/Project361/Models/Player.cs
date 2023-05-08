using System;

/// <summary>
/// Player class has 4 variables:
/// -playerId which is a unique value for each player
/// -nickname which is the nickname that the user enters in
/// -score which is the players current score
/// -currentCardHeld which is the card that the person is currently holding
/// </summary>
public class Player
{
	private int playerId;
	private string nickname;
	private int score;
	Card currentCardHeld;
	public Player(int playerId, string nickname, int score, Card currentCardHeld)
	{
		this.playerId = playerId;
		this.nickname = nickname;
		this.score = score;
		this.currentCardHeld = currentCardHeld;
	}

    public global::System.Int32 PlayerId { get => playerId; set => playerId = value; }
    public global::System.String Nickname { get => nickname; set => nickname = value; }
    public global::System.Int32 Score { get => score; set => score = value; }
    public Card CurrentCardHeld { get => currentCardHeld; set => currentCardHeld = value; }
}
