using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class SwapIntegers
    {
        public void SwapMyIntegers(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;            
        }
    }
}
