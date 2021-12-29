using System;

namespace Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let's create a deck
            Deck deck1 = new Deck();
            Console.WriteLine($"Number of cards left on the deck: {deck1.NumberOfCardsLeft}");
            deck1.DealCard();
            Console.WriteLine($"Number of cards left on the deck: {deck1.NumberOfCardsLeft}");

            Card testCard = new Card(Card.suit.Spades, Card.number.Ace);
            Console.WriteLine($"My card is the {testCard.ToString()}");

            Card testCard2 = new Card(Card.suit.Spades, Card.number.King);
            Console.WriteLine($"My card is the {testCard2.ToString()}");

            BlackjackHand myhand = new BlackjackHand();
            myhand.AddCard(testCard);
            myhand.AddCard(testCard2);

            Console.WriteLine($"Blackjack Value: {myhand.GetBlackjackValue()}");
        }
    }
}
