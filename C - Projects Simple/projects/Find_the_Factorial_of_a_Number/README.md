# 🧮 Factorial Calculator in C

This program calculates the **factorial** of a number using **recursion** in C.

---

## 🔍 What is Factorial?

The **factorial** of a number `n` is the product of all positive integers less than or equal to `n`.  
It's denoted as `n!`

**Examples:**

- `5! = 5 × 4 × 3 × 2 × 1 = 120`
- `0! = 1` (by definition)

---

## 🧑‍💻 Code:

```c
#include <stdio.h>

// Recursive function to calculate factorial
long long factorial(int n) {
    return (n == 0) ? 1 : n * factorial(n - 1);
}

int main() {
    int num;
    printf("Enter a number: ");
    scanf("%d", &num);

    printf("Factorial of %d is %lld\n", num, factorial(num));
    return 0;
}
```

---
## 📌 Explanation:
- `factorial(int n)` is a recursive function:

    - If `n` is `0`, return `1`.

    - Otherwise, return `n × factorial(n - 1)`.

- `main()` takes input from the user and calls the factorial function.

---
## 🚀 Sample Output:

```
Enter a number: 5
Factorial of 5 is 120
```
