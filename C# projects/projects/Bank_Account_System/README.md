# Bank Account System in C#

## 🏦 **Overview**

This program simulates a simple **bank account system** where a user can perform the following operations:
- Deposit money into the account.
- Withdraw money from the account.
- Check the current balance.
- Exit the program.

---

## 💻 **Program Explanation**

1. **`BankAccount` Class**:
   - **Properties**:
     - `AccountHolder`: Stores the name of the account holder.
     - `Balance`: Stores the current balance in the account.
   - **Methods**:
     - `Deposit()`: Adds a specified amount to the balance.
     - `Withdraw()`: Subtracts a specified amount from the balance if there are sufficient funds, otherwise displays an error message.
     - `CheckBalance()`: Displays the current balance.

2. **`Main()` Method**:
   - The program initializes a `BankAccount` object and sets an initial balance.
   - It provides the user with a menu of available commands (`deposit`, `withdraw`, `balance`, `exit`).
   - It repeatedly asks for user input, processes commands, and calls the corresponding methods.

---

## 🧑‍💻 **Code:**

```csharp
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
```

---
## 🚀 Example Run:
- **Input 1:**
```
Enter command:
deposit
Enter amount to deposit:
500
```

- **Output:**
```
Deposited 500. New Balance: 1500
```

- **Input 2:**
```
Enter command:
withdraw
Enter amount to withdraw:
200
```

- **Output:**
```
Withdrew 200. New Balance: 1300
```

- **Input 3:**
```
Enter command:
balance
```

- **Output:**
```
Current Balance: 1300
```

- **Input 4:**
```
Enter command:
exit
```

- **Output:**
```
Exiting program.
```

---
## ⚡ How It Works:
- The program allows you to interact with the bank account by entering commands in a loop until you choose to exit.

- The `Deposit` method adds money to the balance.

- The `Withdraw` method reduces the balance, but only if there are sufficient funds.

- The `CheckBalance` method allows you to view the current account balance at any time.
