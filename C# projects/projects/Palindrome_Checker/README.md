# Palindrome Checker in C#

## 🧑‍💻 **Overview**

This C# program checks if the input string is a palindrome. A palindrome is a word, phrase, or sequence that reads the same backward as forward (ignoring spaces, punctuation, and capitalization).

In this example:
- The program prompts the user to input a string.
- It checks whether the string is a palindrome by comparing the original string to its reversed version.
- The program then displays whether the string is a palindrome or not.

---

## 💻 **Program Explanation**

1. **Palindrome Logic**:
   - The string is reversed using the `Reverse()` method.
   - The original string is compared with the reversed string using `Equals()` method with a case-insensitive comparison.

2. **User Input**:
   - The program asks for a string and checks if it is a palindrome by calling the `IsPalindrome()` method.

3. **Output**:
   - If the string is a palindrome, it prints "The string is a palindrome".
   - Otherwise, it prints "The string is not a palindrome".

---

## 🧑‍💻 **Code:**

```csharp
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
```

---
## 🚀 Example Run:
### Input/Output Example 1:
```
Enter a string:
madam
The string is a palindrome.
```

### Input/Output Example 2:
```
Enter a string:
hello
The string is not a palindrome.
```

---
## 🔍 Explanation:
### Reversing the String:

- The string is reversed using `string.Concat(input.Reverse())`. `Reverse()` is a LINQ method that returns a reversed sequence of characters, and `string.Concat()` combines them into a single string.

### Comparison:

- The original string is compared with the reversed string using `Equals()` method, which checks if both strings are identical ignoring case with `StringComparison.OrdinalIgnoreCase`.

### User Input:

- The program allows the user to input any string and checks if it's a palindrome.
