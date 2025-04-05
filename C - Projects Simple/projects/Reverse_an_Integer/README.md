# 🔄 Reverse Number in C

This C program takes an integer input from the user and reverses the digits of the number.

---

## ⚙️ Logic & Approach

1. The function **`reverseNumber()`** reverses the digits of the input number using a **while loop**:
   - The remainder when the number is divided by 10 (`num % 10`) gives the last digit.
   - The last digit is then added to the reversed number (which is initially 0).
   - The number is divided by 10 to remove the last digit.
2. This process continues until the number becomes 0.
3. The reversed number is then returned.

---

## 💻 Code

```c
#include <stdio.h>

// Function to reverse a number
int reverseNumber(int num) {
    int reversed = 0;
    
    // Repeatedly extract last digit and build reversed number
    while (num != 0) {
        int digit = num % 10;
        reversed = reversed * 10 + digit;
        num /= 10;  // Remove the last digit
    }
    
    return reversed;  // Return the reversed number
}

int main() {
    int num;

    // Ask the user for input
    printf("Enter a number: ");
    scanf("%d", &num);

    // Output the reversed number
    printf("Reversed number: %d\n", reverseNumber(num));
    return 0;
}
```

---
## 🧪 Sample Output
- **Example 1:**

   - **Input:**

```
Enter a number: 12345
```
   - **Output:**
```
Reversed number: 54321
```

- **Example 2:**

   - **Input:**

```
Enter a number: 9876
```
   - **Output:**
```
Reversed number: 6789
```
