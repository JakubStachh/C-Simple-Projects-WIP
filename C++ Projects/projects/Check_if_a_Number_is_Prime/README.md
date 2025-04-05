# Prime Number Checker in C++

## 📝 **Overview**

This C++ program determines if a given number is **prime**. A prime number is a number greater than 1 that has no divisors other than 1 and itself. 

For example:
- **17** is a prime number because it is only divisible by 1 and 17.
- **18** is not a prime number because it has divisors other than 1 and 18 (i.e., 2, 3, 6, 9).

---

## 💻 **Program Explanation**

### **Steps**:
1. **Initial Check**: The program first checks if the number is less than or equal to 1. If so, it returns false since numbers less than or equal to 1 are not prime.
2. **Looping through Potential Divisors**: The program loops through numbers starting from 2 up to the square root of the given number (`sqrt(num)`) to check for any divisors. 
   - If a divisor is found, the number is not prime.
   - If no divisors are found, the number is prime.

---

## 🧑‍💻 **Code:**

```cpp
#include <iostream>

bool isPrime(int num) {
    if (num <= 1) return false;
    for (int i = 2; i * i <= num; i++) {
        if (num % i == 0) return false;
    }
    return true;
}

int main() {
    int num = 17;
    std::cout << num << (isPrime(num) ? " is Prime" : " is not Prime") << std::endl;
    return 0;
}
```

---
## 🚀 How It Works:
### 1. Initial Check:
- The program first checks if the number is less than or equal to 1. Prime numbers are defined as integers greater than 1, so if the number is 1 or lower, the program immediately returns `false`.

### 2. Checking for Divisors:
- The loop iterates through possible divisors from 2 up to the square root of the number. If any number divides the input evenly (i.e., `num % i == 0`), the program returns `false` because the number is not prime.

### 3. Conclusion:
- If the loop completes without finding any divisors, the number is prime, and the program returns `true`.

---
## 🖼️ Sample Output:
### Example 1 - Check for 17:
```csharp
17 is Prime
```

### Example 2 - Check for 18:
```csharp
18 is not Prime
```
