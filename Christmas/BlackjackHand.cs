using System;
using System.Collections.Generic;
using System.Text;

namespace Christmas
{
    class BlackjackHand : Hand
    {
        public int GetBlackjackValue()
        {
            int sum = 0;
            foreach (var card in cards)
            {
                sum += (int)card.Value;
            }
            return sum;
        }
    }
}
