# Basic Calculator in C

## 📝 **Calculator Definition**
A **basic calculator** performs simple arithmetic operations such as addition, subtraction, multiplication, and division. The user inputs an operator and two numbers, and the program calculates the result based on the chosen operation.

---
  
## 📚 **Program Explanation**

1. **Input Section:**
   - **Operator Input**: The program asks the user to input one of the arithmetic operators (`+`, `-`, `*`, `/`).
   - **Numbers Input**: The user is asked to input two floating-point numbers.

2. **Switch Statement:**
   - The program uses a `switch` statement to select the appropriate operation based on the entered operator.
   - Each case of the switch corresponds to one of the arithmetic operations.
   - If the user attempts division by zero, the program returns an error message.

3. **Output Section:**
   - After performing the operation, the program displays the result formatted to two decimal places.
   
---

## 🧑‍💻 **Code:**

```c
#include <stdio.h>

int main() {
    char operator;
    double num1, num2, result;

    // Input the operator
    printf("Enter an operation (+, -, *, /): ");
    scanf(" %c", &operator);

    // Input the numbers
    printf("Enter two numbers: ");
    scanf("%lf %lf", &num1, &num2);

    // Perform the operation based on the operator
    switch(operator) {
        case '+': result = num1 + num2; break; // Addition
        case '-': result = num1 - num2; break; // Subtraction
        case '*': result = num1 * num2; break; // Multiplication
        case '/': 
            if (num2 != 0) result = num1 / num2; // Division
            else {
                printf("Error: Division by zero!\n");
                return 1; // Exit if division by zero
            }
            break;
        default:
            printf("Invalid operation.\n");
            return 1; // Exit if an invalid operation is entered
    }

    // Output the result
    printf("Result: %.2lf\n", result);
    return 0;
}
```
---

## 🚀 Example Run:
**Input:**

```
Enter an operation (+, -, *, /): +
Enter two numbers: 15 20
```

**Output:**

```
Result: 35.00
```

**Input:**

```
Enter an operation (+, -, *, /): /
Enter two numbers: 10 0
```

**Output:**

```
Error: Division by zero!
```

---
## ⚡ How the Program Works:
- The user is prompted to enter an arithmetic operator and two numbers.

- The program checks the operator entered and performs the respective operation:

    - **Addition** (`+`)

    - **Subtraction** (`-`)

    - **Multiplication** (`*`)

    - **Division** (`/`) with a check for division by zero.

- If an invalid operation is entered, the program will notify the user and exit.

- The result is displayed with two decimal points
