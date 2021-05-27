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

            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("Fibonacci recursice solution with return value");
            Console.WriteLine("");
            Console.WriteLine("0");
            
            for (int i = 0; i <= 15; i++)
            {
                Console.WriteLine(RecursiveSolution(i));
            }
        }
        
        //recursive solution
        private static int RecursiveSolution(int n)
        {
            if (n <= 1)
                return 1;
            
            return RecursiveSolution(n - 2) + RecursiveSolution(n - 1);
        }
    }
}