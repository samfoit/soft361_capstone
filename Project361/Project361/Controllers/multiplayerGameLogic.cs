using System;

/// <summary>
/// multiplayerGameLogic uses 2 variables to help it run the game:
/// -players which is an array of Person which represents all the players playing
/// in the turn order (for example players[0] will be the player with the first turn)
/// -deck which is an array of Card which represents the deck of cards
/// </summary>
public class multiplayerGameLogic
{
	/*
	 * Starts the game by taking in an array of players and the card deck. This will set up
	 * everything for the game such as setting each players score to 0.
	 * <parameter>Player array in turn order</parameter>
	 * <parameter>Card array (deck)</parameter>
	 * <return>Updated player array</return>
	 */
	void startGame(Player players[], Card deck[])
	{
		//TODO: write function
	}

    /*
	 * Starts a round by taking in an array of players and the card deck. 
	 * The round will filp a card and then determine who has the highest card
	 * and gets awarded the point
	 * <parameter>Array of player in the turn order</parameter>
	 * <parameter>Card array</parameter>
	 * <return>Updated player array</return>
	 */
    void startRound(Player players[], Card deck[])
    {
        //TODO: write function
    }

    /*
	 * Ends the game by taking in an array of players and the card deck. 
	 * This function will determine who has won.
	 * <parameter>Player array in turn order</parameter>
	 * <parameter>Card array (deck)</parameter>
	 * <return>An array of all the winning players (should only be one
	 * unless there is a tie.</return>
	 */
    void endGame(Player players[], Card deck[])
    {
        //TODO: write function
    }
}
