# Reverse String Program

## 📝 **Overview**

This C++ program reverses a given string using the `std::reverse` function from the `<algorithm>` library. It is a simple yet effective way to reverse a string and display the result.

---

## 💻 **How the Program Works**

### **Steps**:
1. **Input**:
   - The string `str` is initialized with the value `"hello"`.

2. **Reversing Process**:
   - The `std::reverse()` function is used to reverse the string in-place.

3. **Output**:
   - The reversed string is printed to the console.

---

## 🧑‍💻 **Code**:

```cpp
#include <iostream>
#include <algorithm>

int main() {
    std::string str = "hello";
    std::reverse(str.begin(), str.end());
    std::cout << "Reversed string: " << str << std::endl;
    return 0;
}
```

---
## 🚀 How It Works:
### 1. Input String:
- The program begins by initializing the string `str` with the value `"hello"`.

### 2. Reversing Process:
- The `std::reverse()` function is used to reverse the string in-place. It takes two iterators (begin and end) as arguments, and reverses the content between them.

### 3. Output the Reversed String:
- After the string is reversed, the program prints the reversed string using `std::cout`.

---
## 🖼️ Sample Output:
```csharp
Reversed string: olleh
```
In the output:

  - The string `"hello"` has been reversed to `"olleh"`.
