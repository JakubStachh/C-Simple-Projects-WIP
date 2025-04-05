# Factorial Calculator in C++

## 📝 **Overview**

This C++ program calculates the factorial of a given number using a **recursive** approach. The factorial of a non-negative integer `n` is the product of all positive integers less than or equal to `n`. It is denoted as `n!`.

For example:
- `5! = 5 * 4 * 3 * 2 * 1 = 120`
- `0! = 1` (By definition)

---

## 💻 **Program Explanation**

### **Steps**:
1. **Input**: The program takes an integer input `n`.
2. **Recursive Calculation**: It uses a recursive function `factorial()` to compute the factorial of `n`.
3. **Output**: After the computation, the program prints the factorial of the input number.

---

## 🧑‍💻 **Code**:

```cpp
#include <iostream>

long long factorial(int n) {
    return (n == 0 || n == 1) ? 1 : n * factorial(n - 1);
}

int main() {
    int num = 5;
    std::cout << "Factorial of " << num << " is " << factorial(num) << std::endl;
    return 0;
}
```

---
## 🚀 How It Works:
### 1. Recursive Factorial Function:
The `factorial()` function uses recursion to compute the factorial:

- If `n` is `0` or `1`, it returns `1` (since `0! = 1` and `1! = 1`).

- Otherwise, it returns `n * factorial(n - 1)`.

This recursion continues until `n` becomes `1`, where the base case is reached.

### 2. Main Function:
In the `main()` function:

- A number `num` is defined (in this case `5`).

- The `factorial()` function is called with `num` as the argument.

- The result is then printed.


---
## 🖼️ Sample Output:
### Example 1 - `Input: 5`:
```csharp
Factorial of 5 is 120
```

### Example 2 - `Input: 7`:
```csharp
Factorial of 7 is 5040
```
