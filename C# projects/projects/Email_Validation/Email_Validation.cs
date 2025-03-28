using System;
using System.Text.RegularExpressions;

namespace EmailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter email address:");
            string email = Console.ReadLine();

            if (IsValidEmail(email))
            {
                Console.WriteLine("Valid email address.");
            }
            else
            {
                Console.WriteLine("Invalid email address.");
            }
        }

        static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }
}
