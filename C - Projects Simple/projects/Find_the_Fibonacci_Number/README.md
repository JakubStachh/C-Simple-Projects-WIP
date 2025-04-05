# 🔢 Fibonacci Number Generator in C

This C program demonstrates **two methods** to find the `n`th Fibonacci number:
- ✅ Recursive (simple but inefficient)
- ⚡ Iterative (efficient and recommended for large `n`)

---

## 🌱 What is the Fibonacci Sequence?

The **Fibonacci sequence** is a series of numbers where each number is the sum of the two preceding ones:


##
$$
\large \text{0, 1, 1, 2, 3, 5, 8, 13, ...}
$$
##


- `F(0) = 0`
- `F(1) = 1`
- `F(n) = F(n - 1) + F(n - 2)` for `n ≥ 2`

---

## 🧠 Program Logic

### 1. `fibonacciRecursive(int n)`
- Base Case: Returns `n` if `n <= 1`
- Recursive Step: Calls itself for `n - 1` and `n - 2`
- ❌ **Inefficient** for large `n` due to repeated calculations

### 2. `fibonacciIterative(int n)`
- Uses a loop to avoid recursion
- Updates two previous values to generate the next one
- ✅ **Efficient** and fast for large `n`

---

## 💻 Code:

```c
#include <stdio.h>

// Recursive approach (inefficient for large n)
int fibonacciRecursive(int n) {
    if (n <= 1) return n;
    return fibonacciRecursive(n - 1) + fibonacciRecursive(n - 2);
}

// Iterative approach (efficient)
int fibonacciIterative(int n) {
    if (n <= 1) return n;
    int a = 0, b = 1, c;
    for (int i = 2; i <= n; i++) {
        c = a + b;
        a = b;
        b = c;
    }
    return c;
}

int main() {
    int n;
    printf("Enter position: ");
    scanf("%d", &n);
    
    printf("Fibonacci (Recursive): %d\n", fibonacciRecursive(n));
    printf("Fibonacci (Iterative): %d\n", fibonacciIterative(n));

    return 0;
}
🧪 Sample Output
mathematica
Copy
Edit
Enter position: 7
Fibonacci (Recursive): 13
Fibonacci (Iterative): 13
