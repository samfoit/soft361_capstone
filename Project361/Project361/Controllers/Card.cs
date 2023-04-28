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
/// -isFlipped which holds either true or false for if the card is flipped or not
/// </summary>
public class Card
{
	private int cardId;
	private int cardValue;
	private int cardSuite;
	private bool isFlipped;

    enum suite
    {
        HEARTS,
        DIAMONDS,
        SPADES,
        CLUBS
    };

	public Card(int cardId, int cardValue, int cardSuite,  bool isFlipped)
	{
		this.CardId = cardId;
		this.CardValue = cardValue;
		this.CardSuite = cardSuite;
		this.IsFlipped = isFlipped;
	}

    public global::System.Int32 CardId { get => cardId; set => cardId = value; }
    public global::System.Int32 CardValue { get => cardValue; set => cardValue = value; }
    public global::System.Int32 CardSuite { get => cardSuite; set => cardSuite = value; }
    public global::System.Boolean IsFlipped { get => isFlipped; set => isFlipped = value; }

    /// <summary>
    /// Converts card into a string
    /// </summary>
    /// <returns>Card name as a string</returns>
	public string toString()
	{
        string suite;
        if (this.cardSuite == suite.HEARTS) suite = "Hearts";
        else if (this.cardSuite == suite.DIAMONDS) suite = "Diamonds";
        else if (this.cardSuite == suite.SPADES) suite = "Spades";
        else suite = "Clubs";
        string value;
        if (this.cardValue == 1) value = "Ace";
        else if (this.cardValue == 11) value = "Jack";
        else if (this.cardValue == 12) value = "Queen";
        else if (this.cardValue == 13) value = "King";
        else value = string.Format("{0}", this.cardValue); //string.Format https://learn.microsoft.com/en-us/dotnet/api/system.string.format?view=net-8.0#Starting
        return string.Format("{0} of {1}", value, suite);
    }

}
