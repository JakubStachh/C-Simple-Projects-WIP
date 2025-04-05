# 🔡 Vowel and Consonant Counter in C

This program takes a string input and counts the number of **vowels** and **consonants** present in it.

---

## 📘 How It Works

### ✅ Steps:
1. **Input**: The user enters a string.
2. **Processing**:
   - The program iterates through each character of the string.
   - Converts each character to lowercase using `tolower()` for uniformity.
   - Checks if the character is a letter (a-z).
   - Determines if it's a vowel (`a, e, i, o, u`) or a consonant.
3. **Output**: Displays the total count of vowels and consonants.

---

## 💻 Code:

```c
#include <stdio.h>
#include <ctype.h>

void countVowelsConsonants(char *str) {
    int vowels = 0, consonants = 0;

    for (int i = 0; str[i] != '\0'; i++) {
        char ch = tolower(str[i]);
        if (ch >= 'a' && ch <= 'z') {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                vowels++;
            else
                consonants++;
        }
    }

    printf("Vowels: %d, Consonants: %d\n", vowels, consonants);
}

int main() {
    char str[100];

    printf("Enter a string: ");
    scanf("%s", str);

    countVowelsConsonants(str);
    return 0;
}
```

---
## 🧪 Sample Run

```
Enter a string: Education
Vowels: 5, Consonants: 4
```

---
## 🔍 Notes

- Only alphabetic characters are counted.

- The program ignores spaces, digits, and special characters.

- Converts input to lowercase to simplify vowel/consonant checking.

- Uses `scanf("%s", str)`, so input is limited to one word (no spaces). To read full lines, `fgets()` can be used instead.
