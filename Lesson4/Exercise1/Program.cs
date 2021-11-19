using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            var x = Console.ReadLine();            
            NumberMath y = new NumberMath();
            //validate it is a number
            var z = y.GetMyNumber(int.Parse(x));
            Console.WriteLine("The result is: {0}", z);
        }
    }
}
