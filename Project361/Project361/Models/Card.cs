using System;

public class Card
{
    private int _CardId;
    private int _CardValue;
    private int _CardSuite;
    private bool _IsFlipped;

    enum suite
    {
        HEARTS,
        DIAMONDS,
        SPADES,
        CLUBS
    };

    public Card(int CardId, int CardValue, int CardSuite, bool IsFlipped)
    {
        this._CardId = CardId;
        this._CardValue = CardValue;
        this._CardSuite = CardSuite;
        this._IsFlipped = IsFlipped;
    }

    public int CardId
    {
        get => _CardId;
        set => _CardId = value;
    }
    public int CardValue
    {
        get => _CardValue;
        set => _CardValue = value;
    }
    public int CardSuite
    {
        get => _CardSuite;
        set => _CardSuite = value;
    }
    public bool IsFlipped
    {
        get => _IsFlipped;
        set => _IsFlipped = value;
    }

    public string toString()
    {
        string suite_str;
        if (this._CardSuite != (int)suite.HEARTS)
        {
            if (this._CardSuite == (int)suite.DIAMONDS) suite_str = "Diamonds";
            else if (this._CardSuite == (int)suite.SPADES) suite_str = "Spades";
            else suite_str = "Clubs";
        }
        else suite_str = "Hearts";

        string value;
        if (this._CardValue == 1) value = "Ace";
        else if (this._CardValue == 11) value = "Jack";
        else if (this._CardValue == 12) value = "Queen";
        else if (this._CardValue == 13) value = "King";
        else value = this._CardValue.ToString();

        return string.Format("{0} of {1}", value, suite_str);
    }
}
