using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers:");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("The value of a is: {0}", a);
            Console.WriteLine("The value of b is: {0}", b);
            SwapIntegers mySwap = new SwapIntegers();
            mySwap.SwapMyIntegers(ref a, ref b);
            Console.WriteLine("The value of a is: {0}", a);
            Console.WriteLine("The value of b is: {0}", b);
        }
    }
}
