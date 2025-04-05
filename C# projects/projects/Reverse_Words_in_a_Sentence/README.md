# Reverse Words in a Sentence - C# Program

## 🧑‍💻 **Overview**

This C# program takes a sentence as input from the user and reverses the order of words in that sentence. The program splits the sentence into individual words, reverses the order of the words, and then joins them back together to produce the reversed sentence.

---

## 💻 **Program Explanation**

1. **Splitting the Sentence**:
   - The sentence is split into individual words using the `Split()` method.
   
2. **Reversing the Words**:
   - The array of words is reversed using the `Array.Reverse()` method.
   
3. **Joining the Words**:
   - The reversed words are joined back into a single string using the `string.Join()` method.

4. **User Input**:
   - The user is prompted to enter a sentence. After the sentence is reversed, the result is displayed to the user.

---

## 🧑‍💻 **Code:**

```csharp
using System;

namespace ReverseWordsInSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();
            Console.WriteLine("Reversed sentence: " + ReverseWords(sentence));
        }

        static string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
```

---
## 🚀 Example Run:
### Input/Output Example 1:
```
Enter a sentence:
Hello world from C#
Reversed sentence: C# from world Hello
```

### Input/Output Example 2:
```
Enter a sentence:
C# is fun
Reversed sentence: fun is C#
```

---
## 🔍 Explanation:
### Splitting the Sentence:

- The sentence is split by spaces using `sentence.Split(' ')`. This creates an array where each element is a word from the sentence.

### Reversing the Words:

- `Array.Reverse(words)` reverses the order of the words in the array.

### Joining the Words:

- `string.Join(" ", words)` combines the reversed words into a single string, separating each word with a space.

### User Input:

- The program allows the user to input any sentence and returns the reversed word order.
