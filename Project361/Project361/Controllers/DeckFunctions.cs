using System;

public class DeckFunctions
{
    public static Card[] createDeck()
    {
        Card[] deck = new Card[52];
        int currentCard = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 1; j <= 13; j++)
            {
                deck[currentCard] = new Card(currentCard + 1, j, i, false);
                currentCard++;
            }
        }
        return deck;
    }

    public static Card[] shuffleDeck(Card[] deck)
    {
        Random randomNumber = new Random();
        for (int i = 0; i < 52; i++)
        {
            int num = randomNumber.Next(0, 52);
            Card temp = deck[i];
            deck[i] = deck[num];
            deck[num] = temp;
        }
        return deck;
    }
}
