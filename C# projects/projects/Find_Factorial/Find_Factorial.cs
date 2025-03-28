using System;

namespace FactorialProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            // Recursive approach
            Console.WriteLine($"Factorial (Recursive) of {num}: {FactorialRecursive(num)}");

            // Iterative approach
            Console.WriteLine($"Factorial (Iterative) of {num}: {FactorialIterative(num)}");
        }

        static int FactorialRecursive(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * FactorialRecursive(n - 1);
        }

        static int FactorialIterative(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
