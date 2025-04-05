# Armstrong Number Checker in C++

## 📝 **Overview**

This C++ program checks whether a given number is an **Armstrong number** (also known as a **Narcissistic number**). An Armstrong number is a number that is equal to the sum of its own digits each raised to the power of the number of digits.

For example:
- **153** is an Armstrong number because:


$$
\large( 1^3 + 5^3 + 3^3 = 153 \).
$$
##
---

## 💻 **Program Explanation**

### **Steps**:
1. **Calculate Number of Digits**: The program first counts the number of digits in the number.
2. **Sum of Powers**: It then calculates the sum of each digit raised to the power of the total number of digits.
3. **Check Armstrong Condition**: If the sum equals the original number, the program prints that the number is an Armstrong number; otherwise, it is not.

---

## 🧑‍💻 **Code:**

```cpp
#include <iostream>
#include <cmath>

bool isArmstrong(int num) {
    int sum = 0, temp = num, digits = 0;
    
    // Count the number of digits
    while (temp) {
        digits++;
        temp /= 10;
    }

    // Calculate sum of each digit raised to the power of 'digits'
    temp = num;
    while (temp) {
        sum += pow(temp % 10, digits);
        temp /= 10;
    }

    return sum == num; // Check if sum equals original number
}

int main() {
    int num = 153;
    std::cout << num << (isArmstrong(num) ? " is an Armstrong number" : " is not an Armstrong number") << std::endl;
    return 0;
}
```

---
## 🚀 How It Works:
### 1. Count the Number of Digits:
The program calculates the number of digits in the given number using a `while` loop that divides the number by 10 until it becomes 0.

### 2. Sum of Powers:
For each digit in the number, it raises the digit to the power of the number of digits, adds them up, and compares the sum with the original number.

### 3. Final Comparison:
If the sum of the powers equals the original number, it prints that the number is an Armstrong number; otherwise, it prints that it is not.

---
## 🖼️ Sample Output:
### Example 1 - Check for 153:
```csharp
153 is an Armstrong number
```

### Example 2 - Check for a non-Armstrong number (e.g., 123):
```csharp
123 is not an Armstrong number
```
