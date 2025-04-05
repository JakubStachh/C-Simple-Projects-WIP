# Anagram Checker in C#

## 📝 **Anagram Definition**
Two strings are considered **anagrams** if they contain the same characters in any order, and with the same frequency. For example:
  
#### - `"listen"` is an anagram of `"silent"` because both contain the same characters (`l, i, s, t, e, n`).
  
#### - `"evil"` is an anagram of `"vile"` because both contain the same characters (`e, v, i, l`).

---

## 📚 **Program Explanation**

1. **`AreAnagrams()` Function:**
   - **Input**: Two strings `str1` and `str2`.
   - **Process**: 
     1. Convert both strings into character arrays.
     2. Sort the arrays alphabetically.
     3. Compare if the sorted arrays are equal.
   - **Output**: Returns `true` if the strings are anagrams, otherwise `false`.

2. **`Main()` Function:**
   - The program prompts the user to enter two strings.
   - It then calls the `AreAnagrams()` function to check if the strings are anagrams.
   - Based on the result, it prints whether the strings are anagrams.

---

## 🧑‍💻 **Code:**

```csharp
using System;

namespace AnagramChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string:");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter the second string:");
            string str2 = Console.ReadLine();

            if (AreAnagrams(str1, str2))
            {
                Console.WriteLine("The strings are anagrams.");
            }
            else
            {
                Console.WriteLine("The strings are not anagrams.");
            }
        }

        static bool AreAnagrams(string str1, string str2)
        {
            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();
            
            Array.Sort(arr1);
            Array.Sort(arr2);
            
            return new string(arr1) == new string(arr2);
        }
    }
}
```

---
## 🚀 Example Run:
- **Input:**

```csharp
Enter the first string:
listen
Enter the second string:
silent
```
- **Output:**

```csharp
The strings are anagrams.
```

- **Input:**

```csharp
Enter the first string:
hello
Enter the second string:
world
```

- **Output:**

```csharp
The strings are not anagrams.
```

---
## ⚡ How the Program Works:
- The program takes two strings as input and converts them into character arrays.

- The arrays are then sorted, and the sorted arrays are compared.

- If the sorted arrays are equal, the strings are anagrams; otherwise, they are not.
