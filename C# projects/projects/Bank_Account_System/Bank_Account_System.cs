using System;

namespace BankAccountSystem
{
    class BankAccount
    {
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount}. New Balance: {Balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount}. New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Current Balance: {Balance}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.AccountHolder = "John Doe";
            account.Balance = 1000.0; // Initial balance

            string command;
            double amount;

            Console.WriteLine("Welcome to the Bank Account System");
            Console.WriteLine("Commands: deposit, withdraw, balance, exit");

            do
            {
                Console.WriteLine("\nEnter command:");
                command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "deposit":
                        Console.WriteLine("Enter amount to deposit:");
                        amount = Convert.ToDouble(Console.ReadLine());
                        account.Deposit(amount);
                        break;

                    case "withdraw":
                        Console.WriteLine("Enter amount to withdraw:");
                        amount = Convert.ToDouble(Console.ReadLine());
                        account.Withdraw(amount);
                        break;

                    case "balance":
                        account.CheckBalance();
                        break;

                    case "exit":
                        Console.WriteLine("Exiting program.");
                        break;

                    default:
                        Console.WriteLine("Invalid command. Try again.");
                        break;
                }
            } while (command != "exit");
        }
    }
}
