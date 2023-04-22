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
/// -isFlipped which holds either true or false for if the card is flipped or not
/// </summary>
public class Card
{
	private int cardId;
	private int cardValue;
	private int cardSuite;
	private string cardName;
	private bool isFlipped;
	public Card(int cardId, int cardValue, int cardSuite, string cardName, bool isFlipped)
	{
		this.CardId = cardId;
		this.CardValue = cardValue;
		this.CardSuite = cardSuite;
		this.CardName = cardName;
		this.IsFlipped = isFlipped;
	}

    public global::System.Int32 CardId { get => cardId; set => cardId = value; }
    public global::System.Int32 CardValue { get => cardValue; set => cardValue = value; }
    public global::System.Int32 CardSuite { get => cardSuite; set => cardSuite = value; }
    public global::System.String CardName { get => cardName; set => cardName = value; }
    public global::System.Boolean IsFlipped { get => isFlipped; set => isFlipped = value; }

}
