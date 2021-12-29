using System;
using System.Collections.Generic;
using System.Text;

namespace Christmas
{
    class Hand
    {        
        public int NumberOfCardsInHand { get; private set; }
        protected List<Card> cards;

        public Hand()
        {
            NumberOfCardsInHand = 0;
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            NumberOfCardsInHand++;
            cards.Add(card);
        }

        public void RemoveCard(Card card)
        {
            NumberOfCardsInHand--;
            cards.Remove(card);
        }

        public void RemoveCard(int cardPosition)
        {
            NumberOfCardsInHand--;
            cards.RemoveAt(cardPosition);
        }

        public void SortBySuit()
        { }

        public void SortByNumber()
        { }

        public Card this[int index]
        {
            get { return cards[index]; }
            set { cards[index] = value; }
        }
    }
}
