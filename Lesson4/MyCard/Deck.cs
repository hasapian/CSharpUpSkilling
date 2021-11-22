using System;
using System.Collections.Generic;
using System.Text;

namespace MyCard
{
    public class Deck
    {
        public int CardsLeft;
        private Card[] cards;

        public void Shuffle()
        { }

        public Card DealCard()
        {
            return new Card();
        }
    }
}
