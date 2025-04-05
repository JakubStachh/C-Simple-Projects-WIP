# Email Validator in C#

## 📧 **Overview**

This program validates an email address entered by the user. It checks whether the input follows a valid email format using regular expressions.

---

## 💻 **Program Explanation**

1. **`IsValidEmail` Method**:
   - Takes an email string as input.
   - Uses a regular expression pattern to check if the email matches the expected format.
   - The pattern matches most typical email formats such as `example@domain.com`.

2. **`Main` Method**:
   - Asks the user to enter an email address.
   - Calls the `IsValidEmail` method to verify the email format.
   - Displays whether the email is valid or invalid based on the result.

---

## 🧑‍💻 **Code:**

```csharp
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
```

---
## 🚀 Example Run:
- **Input 1:**
```
Enter email address:
test@example.com
```

- **Output:**
```
Valid email address.
```

- **Input 2:**
```
Enter email address:
invalid-email
```

- **Output:**
```
Invalid email address.
```

---
## ⚡ How It Works:
- The program prompts the user to enter an email address.

- It uses a regular expression (`Regex`) to check if the email follows a standard format (`e.g., user@domain.com`).

- If the email matches the pattern, it outputs "Valid email address." Otherwise, it returns "Invalid email address."
