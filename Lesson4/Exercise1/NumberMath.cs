using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class NumberMath
    {
        public double GetMyNumber(double number)
        {
            if (number < 0)
                return number * number;
            else
                return Math.Sqrt(number);
        }
    }
}
