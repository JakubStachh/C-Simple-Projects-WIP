# Swap Two Variables Without Using a Temporary Variable

## 📝 **Overview**

This C++ program demonstrates how to swap the values of two variables without using a temporary variable. It uses basic arithmetic operations to perform the swap.

---

## 💻 **How the Program Works**

### **Steps**:
1. **Initialization**:
   - Two integer variables `a` and `b` are initialized with values `5` and `10` respectively.

2. **Swapping Values**:
   - The swapping process is done using the following steps:
     - `a = a + b`: The value of `a` is updated to the sum of `a` and `b`.
     - `b = a - b`: The value of `b` is updated to the new value of `a` (which is the sum of `a` and `b`), and by subtracting the original value of `b`, we get the original value of `a`.
     - `a = a - b`: Finally, the value of `a` is updated by subtracting the new value of `b`, resulting in the original value of `b`.

3. **Output**:
   - The program prints the swapped values of `a` and `b`.

---

## 🧑‍💻 **Code**:

```cpp
#include <iostream>

int main() {
    int a = 5, b = 10;
    a = a + b;
    b = a - b;
    a = a - b;
    
    std::cout << "After swapping: a = " << a << ", b = " << b << std::endl;
    return 0;
}
```

---
## 🚀 How It Works:
### 1. Input Variables:
- Initially, `a = 5` and `b = 10`.

### 2. Swapping Process:
- The following arithmetic operations swap the values of `a` and `b`:

   - `a = a + b;`: This gives `a = 15`.

   - `b = a - b;`: This gives `b = 5` (because `15 - 10 = 5`).

   - `a = a - b;`: This gives `a = 10` (because `15 - 5 = 10`).

### 3. Output the Result:
- The program outputs the swapped values: `a = 10` and `b = 5`.

----
## 🖼️ Sample Output:
```yaml
After swapping: a = 10, b = 5
```
