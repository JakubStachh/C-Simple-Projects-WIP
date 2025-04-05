# String Length Calculation in C++

## 📝 **Overview**

This C++ program calculates the length of a given string manually by iterating through the string characters until the null-terminator (`'\0'`) is reached. This approach avoids using the built-in `std::string::length()` function.

---

## 💻 **Program Explanation**

### **Steps**:

1. **Input**: The program takes a string (`"Hello, World!"` in this case).

2. **Length Calculation**: The function `stringLength()` calculates the length of the string by counting characters until the null-terminator (`'\0'`).

3. **Output**: The program prints the length of the string.

---

## 🧑‍💻 **Code**:

```cpp
#include <iostream>

int stringLength(const std::string &str) {
    int length = 0;
    while (str[length] != '\0') {
        length++;
    }
    return length;
}

int main() {
    std::string str = "Hello, World!";
    std::cout << "Length of string: " << stringLength(str) << std::endl;
    return 0;
}
```

---
## 🚀 How It Works:
### 1. Custom `stringLength()` Function:
- This function receives a string as an argument.

- A variable `length` is initialized to `0`.

- The program iterates through the string using a `while` loop, checking if the character is not the null-terminator (`'\0'`).

- For each character, `length` is incremented until the null-terminator is found, indicating the end of the string.

### 2. `Main` Function:
- In the `main()` function, a string `"Hello, World!"` is provided.

- The `stringLength()` function is called to calculate the string's length.

- The length is printed to the console.

---
## 🖼️ Sample Output:
### Example - Output for `"Hello, World!"`:
```csharp
Length of string: 13
```
This is the length of the string `"Hello, World!"` excluding the null-terminator.
