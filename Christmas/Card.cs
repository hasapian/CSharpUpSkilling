using System;
using System.Collections.Generic;
using System.Text;

namespace Christmas
{
    class Card
    {
        public enum suit
        {
            Spades,
            Diamonds,
            Clubs,
            Hearts
        }

        public enum number
        {
            Ace = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }

        public number Value { get; }
        public suit Suit { get; }

        public Card(suit cardSuit, number value)
        {
            Suit = cardSuit;
            Value = value;
        }

        /*
         * GetSuiteAsString()
         * GetValueAsString()
         */

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
