using System;
using System.Collections.Generic;
using System.Text;

namespace MyCard
{
    public class Hand
    {
        public int Count;

        public void ShortBySuit()
        { }

        public void ShortByNymber()
        { }

        public void Clear()
        { }

        public void AddCard(Card myCard)
        { }

        public void RemoveCard(Card myCard)
        { }

        public void RemoveCard(int value)
        { }

        public int GetBlackJackValue()
        {
            return 0;
        }
    }
}
