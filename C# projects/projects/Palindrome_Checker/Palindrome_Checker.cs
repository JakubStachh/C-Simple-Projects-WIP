using System;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            
            if (IsPalindrome(input))
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
        }

        static bool IsPalindrome(string input)
        {
            string reversed = string.Concat(input.Reverse());
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }
}
