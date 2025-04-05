# 🔄 Reverse String in C

This C program takes a string and reverses it in-place using the **two-pointer** approach. The string is reversed by swapping characters from both ends towards the center.

---

## ⚙️ Logic & Approach

1. The function **`reverseString()`** uses two pointers:
   - One starting from the beginning (`left`) and one from the end (`right`).
2. It swaps the characters at the `left` and `right` indices until the pointers meet in the middle.
3. The string is modified in place, and no additional memory is used for the reversed string.

---

## 💻 Code

```c
#include <stdio.h>
#include <string.h>

// Function to reverse a string
void reverseString(char *str) {
    int left = 0, right = strlen(str) - 1;
    
    // Swap characters from both ends towards the center
    while (left < right) {
        char temp = str[left];
        str[left] = str[right];
        str[right] = temp;
        left++;
        right--;
    }
}

int main() {
    char str[] = "hello";  // Original string
    reverseString(str);  // Reverse the string
    printf("Reversed string: %s\n", str);  // Output the reversed string
    return 0;
}
```

---
## 🧪 Sample Output
**Output:**
```
Reversed string: olleh
```
