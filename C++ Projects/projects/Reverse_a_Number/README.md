# Reverse Number Program

## 📝 **Overview**

This C++ program reverses a given integer. The program works by iterating through each digit of the number and constructing the reversed number.

---

## 💻 **How the Program Works**

### **Steps**:
1. **Input**:
   - A number is provided as input, for example, `12345`.
   
2. **Reversing Process**:
   - The `reverseNumber()` function reverses the given number by repeatedly extracting the last digit and constructing a new number in reverse order.

3. **Output**:
   - The program prints the reversed number.

---

## 🧑‍💻 **Code**:

```cpp
#include <iostream>

int reverseNumber(int num) {
    int rev = 0;
    while (num > 0) {
        rev = rev * 10 + num % 10;
        num /= 10;
    }
    return rev;
}

int main() {
    int num = 12345;
    std::cout << "Reversed number: " << reverseNumber(num) << std::endl;
    return 0;
}
```

---
## 🚀 How It Works:
### 1. Input Number:
- The program begins by initializing the number num that you want to reverse. In the example, `num = 12345`.

### 2. Reversing Process:
- The `reverseNumber()` function takes the input number and extracts each digit using modulus (`% 10`) and builds the reversed number by multiplying the current reversed number by 10 and adding the extracted digit.

### 3. Output the Reversed Number:
- Once all digits are processed, the function returns the reversed number, and the program prints it.

---
## 🖼️ Sample Output:
```yaml
Reversed number: 54321
```
### In the output:

   - The number `12345` has been reversed to `54321`.
