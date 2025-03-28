using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Fibonacci number position:");
            int n = int.Parse(Console.ReadLine());
            
            // Recursive approach
            Console.WriteLine($"Fibonacci (Recursive) at position {n}: {FibonacciRecursive(n)}");

            // Iterative approach
            Console.WriteLine($"Fibonacci (Iterative) at position {n}: {FibonacciIterative(n)}");
        }

        static int FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        static int FibonacciIterative(int n)
        {
            if (n <= 1)
                return n;
            
            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
