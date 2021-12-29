using System;
using System.Collections.Generic;
using System.Text;

namespace Christmas
{
    class Deck
    {
        private int totalCardNumber;

        public int NumberOfCardsLeft { get; private set; }
        public Deck()
        {
            totalCardNumber = 52;
            NumberOfCardsLeft = 52;
        }

        public void Shuffle()
        {
            //rearrange cards into a random order
        }

        public Card DealCard()  //Card return
        {
            // get the next card from the Deck
            //throw an exception when no other card is on the deck
            NumberOfCardsLeft--;
            return new Card(Card.suit.Hearts, Card.number.Ten);            
        }
    }
}
