using System;

/// <summary>
/// multiplayerGameLogic uses 2 variables to help it run the game:
/// -players which is an array of Person which represents all the players playing
/// in the turn order (for example players[0] will be the player with the first turn)
/// -deck which is an array of Card which represents the deck of cards
/// </summary>
public class multiplayerGameLogic
{
	private Person players[];
	private Card deck[];
	public multiplayerGameLogic(Person players[], Card deck[])
	{
		this.players = players;
		this.deck = deck;
	}
	
	/*
	 * Starts the game by taking in an array of players and the card deck
	 */
	void startGame(Player players[], Card deck[])
	{
		//TODO: write function
	}

    /*
	 * Starts a round by taking in an array of players and the card deck
	 */
    void startRound(Player players[], Card deck[])
    {
        //TODO: write function
    }

    /*
	 * Ends the game by taking in an array of players and the card deck
	 */
    void endGame(Player players[], Card deck[])
    {
        //TODO: write function
    }
}
