# Simple Calculator Program

## 📝 **Overview**

This is a simple C++ calculator program that takes two numbers and an operator as input and performs basic arithmetic operations (+, -, *, /). The program checks for division by zero and handles invalid operators.

---

## 💻 **How the Program Works**

### **Steps**:
1. **Input**:
   - The program prompts the user to enter two numbers.
   - It asks for an operator (one of `+`, `-`, `*`, `/`).
   
2. **Processing**:
   - Depending on the operator entered, the program performs the corresponding arithmetic operation.
   - If the operator is `/` (division), the program checks if the second number is not zero before performing the division to avoid division by zero errors.

3. **Output**:
   - The result of the operation is displayed to the user.
   - If the operator is invalid or division by zero is attempted, appropriate error messages are displayed.

---

## 🧑‍💻 **Code**:

```cpp
#include <iostream>

int main() {
    double num1, num2;
    char op;

    std::cout << "Enter two numbers: ";
    std::cin >> num1 >> num2;

    std::cout << "Enter operator (+, -, *, /): ";
    std::cin >> op;

    switch (op) {
        case '+':
            std::cout << "Result: " << num1 + num2 << std::endl;
            break;
        case '-':
            std::cout << "Result: " << num1 - num2 << std::endl;
            break;
        case '*':
            std::cout << "Result: " << num1 * num2 << std::endl;
            break;
        case '/':
            if (num2 != 0)
                std::cout << "Result: " << num1 / num2 << std::endl;
            else
                std::cout << "Error: Division by zero" << std::endl;
            break;
        default:
            std::cout << "Invalid operator!" << std::endl;
    }

    return 0;
}
```

---
## 🚀 How It Works:
### 1. Input and Operator Handling:
- The program uses `std::cin` to get two floating-point numbers from the user and an operator (`+`, `-`, `*`, or `/`).

- Based on the operator entered, it proceeds to the corresponding case in the `switch` statement.

### 2. Switch-Case for Arithmetic Operations:
- **Addition**: If the operator is `+`, the program adds the two numbers and prints the result.

- **Subtraction**: If the operator is `-`, the program subtracts the second number from the first and prints the result.

- **Multiplication**: If the operator is `*`, the program multiplies the two numbers and prints the result.

- **Division**: If the operator is `/`, the program checks if the second number is not zero. If it's zero, it prints an error message; otherwise, it divides the first number by the second and prints the result.

### 3. Error Handling:
- If the operator entered is not valid (not one of `+`, `-`, `*`, `/`), the program prints an error message indicating the invalid operator.

- It also checks for division by zero before performing division.

---
## 🖼️ Sample Output:
### Example 1 - Addition:
```vbnet
Enter two numbers: 5 3
Enter operator (+, -, *, /): +
Result: 8
```

### Example 2 - Division by zero:
```vbnet
Enter two numbers: 5 0
Enter operator (+, -, *, /): /
Error: Division by zero
```

### Example 3 - Invalid operator:
```kotlin
Enter two numbers: 5 3
Enter operator (+, -, *, /): ^
Invalid operator!
```
