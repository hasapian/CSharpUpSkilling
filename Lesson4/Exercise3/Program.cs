using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {            
            int i = 0;
            double numericValue;
            do
            {
                Console.WriteLine("Enter string");
                string stringEntered = Console.ReadLine();
                var result = MyClass.MyMethod(stringEntered, out numericValue);
                if (result)
                    Console.WriteLine("Numeric value: {0}", numericValue);
                i++;
            } while (i < 3);
        }
    }
}
