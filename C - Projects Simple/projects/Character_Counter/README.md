# 🔤 Count Character Frequency in a Text (C Program)

## 📝 **Program Description**
This program takes a line of text and a character as input, then counts how many times that character appears in the text. It's a great example of working with strings, loops, and character operations in C.

---

## 📚 **Program Explanation**

1. **Input Section:**
   - The user is asked to input a string (up to 500 characters).
   - Then the user inputs a single character to search for.

2. **Counting Logic:**
   - The program uses a `for` loop to iterate over each character in the string.
   - It checks whether each character matches the target character.
   - A counter is incremented every time a match is found.

3. **Output Section:**
   - Displays how many times the entered character appears in the input text.

---

## 🧑‍💻 **Code:**

```c
#include <stdio.h>
#include <string.h>

int main() {
    char text[500], ch;
    int count = 0;

    printf("Enter a text (max 500 characters):\n");
    getchar(); // Clear input buffer before reading line
    fgets(text, sizeof(text), stdin);

    printf("Enter a character to count: ");
    scanf(" %c", &ch);

    for (int i = 0; i < strlen(text); i++) {
        if (text[i] == ch) count++;
    }

    printf("The character '%c' appears %d times.\n", ch, count);
    return 0;
}
```
---

## 🚀 Example Run
**Input:**

```
Enter a text (max 500 characters):
Programming is powerful and practical.
Enter a character to count: p
```

**Output:**

```
The character 'p' appears 2 times.
```

---

## ⚡ How the Program Works
- `fgets()` is used to safely capture the entire line of text including spaces.

- `scanf(" %c", &ch)` reads the character to count (note the space to consume newline).

- The loop runs through the text and increments a counter whenever a match is found.

- At the end, the total count is printed to the user.
