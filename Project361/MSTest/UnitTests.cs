namespace MSTest
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void ToStringTests()
        {
            Card card = new(0, 9, 2, false);
            Assert.AreEqual("9 of Spades", card.toString());
            card = new(1, 11, 1, true);
            Assert.AreEqual("Jack of Diamonds", card.toString());
            card = new(2, 12, 3, false);
            Assert.AreEqual("Queen of Clubs", card.toString());
            card = new(3, 13, 0, false);
            Assert.AreEqual("King of Hearts", card.toString());
            card = new(4, 1, 2, false);
            Assert.AreEqual("Ace of Spades", card.toString());
        }
    }

    [TestClass]
    public class DeckFunctionTests
    {
        [TestMethod]
        public void CreateDeckTest()
        {
            Card[] StandardDeck = DeckFunctions.createDeck();
            Assert.AreEqual(52, StandardDeck.Distinct().Count());
        }

        [TestMethod]
        public void CardShuffle()
        {
            Card[] StandardDeck = DeckFunctions.createDeck();
            Card[] ShuffledDeck = DeckFunctions.shuffleDeck(StandardDeck);
            Assert.AreEqual(52, ShuffledDeck.Distinct().Count());
        }
    }
}