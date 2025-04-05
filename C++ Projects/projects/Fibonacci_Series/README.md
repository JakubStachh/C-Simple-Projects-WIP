# Fibonacci Series in C++

## 📝 **Overview**

This C++ program calculates the Fibonacci series up to a given number `n` using a **recursive** approach. In a Fibonacci series, each number is the sum of the two preceding ones, usually starting with `0` and `1`.

The series looks like this:
- `0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...`

The recursive approach calculates the Fibonacci number at each position by calling the function with previous two indices.

---

## 💻 **Program Explanation**

### **Steps**:
1. **Input**: The program calculates Fibonacci numbers for a fixed `n` (in this case, `n = 10`).
2. **Recursive Calculation**: The function `fibonacci(n)` calculates the Fibonacci number at the `n`-th position.
3. **Output**: The program prints the Fibonacci sequence from position `0` to `n-1`.

---

## 🧑‍💻 **Code**:

```cpp
#include <iostream>

int fibonacci(int n) {
    if (n <= 1) return n;
    return fibonacci(n - 1) + fibonacci(n - 2);
}

int main() {
    int n = 10;
    for (int i = 0; i < n; i++) {
        std::cout << fibonacci(i) << " ";
    }
    return 0;
}
```

---
## 🚀 How It Works:
### 1. Recursive Fibonacci Function:
The function `fibonacci(n)` calculates the Fibonacci number at position `n`:

- If `n <= 1`, it returns `n` (i.e., Fibonacci of 0 is `0` and Fibonacci of 1 is `1`).

- Otherwise, it calculates `fibonacci(n-1) + fibonacci(n-2)` recursively.

This recursive process continues until the base cases (`n = 0` or `n = 1`) are reached.

### 2. Main Function:
In the `main()` function:

- The loop runs from `0` to `n-1` (where `n` is `10`).

- For each `i`, the `fibonacci(i)` function is called, and the result is printed.

---
## 🖼️ Sample Output:
### Example - Output for `n = 10`:
```
0 1 1 2 3 5 8 13 21 34 
```
This is the Fibonacci sequence for the first 10 positions starting from `0`.
