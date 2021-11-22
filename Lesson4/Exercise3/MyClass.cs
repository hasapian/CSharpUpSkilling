using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class MyClass
    {
        public static bool MyMethod(string myString, out double myDouble)
        {
            if (double.TryParse(myString, out myDouble) && (myDouble <0))         
                return true;
            else
                return false;
        }
    }
}
