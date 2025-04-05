# GCD Calculation in C++

## 📝 **Overview**

This C++ program calculates the **Greatest Common Divisor (GCD)** of two numbers using the **Euclidean algorithm**. The algorithm works by repeatedly replacing the larger number by its remainder when divided by the smaller number, until the remainder is zero. The last non-zero remainder is the GCD.

---

## 💻 **Program Explanation**

### **Steps**:
1. **Input**: The program takes two integers (in this case, 56 and 98).
2. **GCD Calculation**: The function `gcd()` uses recursion to calculate the GCD of the two numbers.
3. **Output**: The program prints the GCD of the two input numbers.

---

## 🧑‍💻 **Code**:

```cpp
#include <iostream>

int gcd(int a, int b) {
    if (b == 0) return a;  // Base case: when b is zero, a is the GCD
    return gcd(b, a % b);   // Recursive step: apply Euclidean algorithm
}

int main() {
    int a = 56, b = 98;
    std::cout << "GCD of " << a << " and " << b << " is " << gcd(a, b) << std::endl;
    return 0;
}
```

---
## 🚀 How It Works:
### 1. The `gcd()` Function:
- The function uses the Euclidean algorithm for calculating the GCD of two numbers `a` and `b`.

- The function checks if `b == 0`:

    - If true, the function returns `a` as the GCD (since the GCD of any number and 0 is the number itself).

    - Otherwise, it recursively calls `gcd(b, a % b)`, where `%` is the modulus operator. This process continues until the remainder (`a % b`) becomes 0.

### 2. `Main` Function:
- In the `main()` function, two integers, `a = 56` and `b = 98`, are provided.

- The `gcd()` function is called with these two values, and the result is printed to the console.


---
## 🖼️ Sample Output:
### Example - Output for `a = 56`, `b = 98`:
```csharp
GCD of 56 and 98 is 14
```
This is the greatest common divisor of 56 and 98, which is 14.
