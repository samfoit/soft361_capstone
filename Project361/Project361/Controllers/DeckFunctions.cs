using System;

public class DeckFunctions //TODO: Unit Testing
{
    /*
    * The createDeck function will create an array of 52 cards.
    * The deck that is returned from this function is unshuffled.
    * Each Cards isFlipped is automatically set to 0.
    * <return>An array of cards</return>
    */
    public static Card[] createDeck()
    {
        Card[] deck = new Card[52];
        int currentCard = 0;
        for(int i = 0; i < 4; i++)
        {
            for(int j = 1; j <= 13; j++)
            {
                currentCard++;
                deck[currentCard] = new Card(currentCard, j, i, 0);
            }
        }
        return deck;
    }

    /*
	 * This function will shuffle the given deck and return the shuffled deck.
	 * <parameter>Array of card (deck)</parameter>
	 * <return>Shuffled array of cards</return>
	 */
    public static Card[] shuffleDeck(Card[] deck)
    {
        Random randomNumber = new Random(); //Random https://www.tutorialsteacher.com/articles/generate-random-numbers-in-csharp
        for (int i = 0; i < 52; i++)
        {
            int num = randomNumber.next(1, 52);
            Card temp = deck[i];
            deck[i] = deck[num];
            deck[num] = temp;
        }
        return deck;
    }
}
