# 🧮 Multiplication Table in C

This C program prints a **multiplication table** from `1 x 1` to `10 x 10`. It uses **nested loops** to generate and display the results in a neatly formatted table.

---

## ⚙️ Logic & Approach

1. The outer loop iterates through the numbers `1` to `10` for the rows of the multiplication table.
2. The inner loop also iterates through the numbers `1` to `10` for the columns of the multiplication table.
3. For each pair of numbers, the product of the outer loop and inner loop index is calculated and printed.
4. The results are printed with proper spacing for easy readability.

---

## 💻 Code

```c
#include <stdio.h>

int main() {
    for (int i = 1; i <= 10; i++) {  // Outer loop for rows
        for (int j = 1; j <= 10; j++) {  // Inner loop for columns
            printf("%4d", i * j);  // Print the product with spacing
        }
        printf("\n");  // Newline after each row
    }
    return 0;
}
```

---
## 🧪 Sample Output
**Output:**

```
   1   2   3   4   5   6   7   8   9  10
   2   4   6   8  10  12  14  16  18  20
   3   6   9  12  15  18  21  24  27  30
   4   8  12  16  20  24  28  32  36  40
   5  10  15  20  25  30  35  40  45  50
   6  12  18  24  30  36  42  48  54  60
   7  14  21  28  35  42  49  56  63  70
   8  16  24  32  40  48  56  64  72  80
   9  18  27  36  45  54  63  72  81  90
  10  20  30  40  50  60  70  80  90 100
```
