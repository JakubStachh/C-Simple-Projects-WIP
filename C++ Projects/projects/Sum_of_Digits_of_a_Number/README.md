# Sum of Digits Program

## 📝 **Overview**

This C++ program calculates the sum of the digits of a given number. It uses a simple loop to extract each digit and add it to the sum. The program works by repeatedly dividing the number by 10 and extracting the last digit using the modulo operator.

---

## 💻 **How the Program Works**

### **Steps**:
1. **Input**:
   - The program takes a number as input (in this case, it's hardcoded to `12345`).

2. **Sum of Digits**:
   - The `sumOfDigits()` function extracts each digit from the number by using the modulo operator (`%`) and adds it to the sum.
   - The number is then divided by 10 to remove the last digit, and the process repeats until the number becomes 0.

3. **Output**:
   - After calculating the sum, the program prints the result.

---

## 🧑‍💻 **Code**:

```cpp
#include <iostream>

int sumOfDigits(int num) {
    int sum = 0;
    while (num != 0) {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

int main() {
    int num = 12345;
    std::cout << "Sum of digits: " << sumOfDigits(num) << std::endl;
    return 0;
}
```

---
## 🚀 How It Works:
### 1. Input Number:
- The program works with a hardcoded input number, `12345`.

### 2. Sum of Digits:
- The `sumOfDigits()` function:

    - Extracts the last digit using `num % 10` (modulo operator).

    - Adds the digit to the sum.

    - Divides the number by 10 to remove the last digit (`num /= 10`).

    - Repeats the process until all digits are processed (when the number becomes 0).

### 3. Output the Result:
- The program outputs the sum of digits of the number.

---
## 🖼️ Sample Output:
```yaml
Sum of digits: 15
```
### In the output:

  - For the input number `12345`, the sum of the digits is calculated as `1 + 2 + 3 + 4 + 5 = 15`.
