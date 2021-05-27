using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci loop solution");

            var number1 = 0 ;
            var number2 = 1;

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            
            for (int i = 0; i <= 15; i++)
            {
                var next = number1 + number2;
                number1 = number2;
                number2 = next;

                Console.WriteLine(next);
            }
        }
    }
}