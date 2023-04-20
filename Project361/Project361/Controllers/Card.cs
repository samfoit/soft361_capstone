using System;

/// <summary>
/// Card class which has 4 variables:
/// -cardId which holds a value (up to 52) for each card
/// -cardValue which holds the value of the card (for example ace is 1 and king is 13
/// -cardSuite which holds a number for the suite:
///    -Hearts = 0
///    -Diamonds = 1
///    -Spades = 2
///    -Clubs = 3
/// -cardName which holds a string of the exact card name (for example "5 of diamonds")
/// </summary>
public class Card
{
	private int cardId;
	private int cardValue;
	private int cardSuite;
	private string cardName;
	public Card(int cardId, int cardValue, int cardSuite, string cardName)
	{
		this.CardId = cardId;
		this.CardValue = cardValue;
		this.CardSuite = cardSuite;
		this.CardName = cardName;
	}

    public global::System.Int32 CardId { get => cardId; set => cardId = value; }
    public global::System.Int32 CardValue { get => cardValue; set => cardValue = value; }
    public global::System.Int32 CardSuite { get => cardSuite; set => cardSuite = value; }
    public global::System.String CardName { get => cardName; set => cardName = value; }
	
	/*
	 * The createDeck function will create an array of 52 cards.
	 * The deck that is returned from this function is unshuffled
	 */
	public Card[] createDeck()
	{
		//TODO: write function
	}

	/*
	 * This function will shuffle the given deck and return the shuffled deck.
	 */
	public Card[] shuffleDeck(Card[] deck)
	{
		//TODO: write function
	}
}
