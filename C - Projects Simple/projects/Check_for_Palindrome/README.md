# 🔁 Palindrome Checker in C (String & Number)

## 📝 **What is a Palindrome?**
A **palindrome** is a word, phrase, number, or other sequence that reads the same forwards and backwards.

### Examples:
- ✅ `"racecar"` → Palindrome
- ❌ `"hello"` → Not a palindrome
- ✅ `121` → Palindrome
- ❌ `123` → Not a palindrome

---

## 📚 **Program Overview**

This program:
- Checks if a **string** is a palindrome.
- Checks if a **number** is a palindrome.

It includes:
- A function for checking string palindromes.
- A function for checking numeric palindromes.
- A `main()` function that demonstrates both.

---

## 🧑‍💻 **Code:**

```c
#include <stdio.h>
#include <string.h>

// ✅ Check if a string is a palindrome
int isPalindromeString(char *str) {
    int left = 0, right = strlen(str) - 1;
    while (left < right) {
        if (str[left++] != str[right--]) return 0;
    }
    return 1;
}

// ✅ Check if a number is a palindrome
int isPalindromeNumber(int num) {
    int original = num, reversed = 0;
    while (num > 0) {
        reversed = reversed * 10 + (num % 10);
        num /= 10;
    }
    return original == reversed;
}

int main() {
    char str[] = "racecar";
    int num = 121;

    printf("Is '%s' a palindrome? %s\n", str, isPalindromeString(str) ? "Yes" : "No");
    printf("Is %d a palindrome? %s\n", num, isPalindromeNumber(num) ? "Yes" : "No");

    return 0;
}
```

---

## 🚀 Example Output
```
Is 'racecar' a palindrome? Yes
Is 121 a palindrome? Yes
```
---
## 🔍 How It Works
### 📌 `isPalindromeString()`:
- Uses two pointers (`left` and `right`) to compare characters from both ends of the string.

- Returns `1` if all characters match, `0` otherwise.

### 📌 `isPalindromeNumber()`:
- Reverses the number using **modulo** (`%`) and **division** (`/`).

- Compares the reversed number to the original.
