# Vowels and Consonants Counter in C++

## 📝 **Overview**

This C++ program counts the number of vowels and consonants in a given string. It filters out any non-alphabetic characters and treats uppercase and lowercase letters equally by converting them to lowercase.

---

## 💻 **Program Explanation**

### **Steps**:

1. **Input**: The program takes an input string.

2. **Iterate Through Characters**: It iterates through each character in the string.
   - It checks if the character is an alphabet letter.
   - It counts vowels (a, e, i, o, u) and consonants (all other alphabet letters).

3. **Output**: After processing the string, the program outputs the total number of vowels and consonants.

---

## 🧑‍💻 **Code:**

```cpp
#include <iostream>
#include <cctype>

void countVowelsAndConsonants(const std::string &str) {
    int vowels = 0, consonants = 0;
    
    for (char c : str) {
        c = std::tolower(c);
        if (isalpha(c)) {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') {
                vowels++;
            } else {
                consonants++;
            }
        }
    }

    std::cout << "Vowels: " << vowels << ", Consonants: " << consonants << std::endl;
}

int main() {
    std::string str = "Hello World!";
    countVowelsAndConsonants(str);
    return 0;
}
```

---
## 🚀 How It Works:
### 1. Convert to Lowercase:
- The program uses `std::tolower()` to ensure that case differences (e.g., `'A'` and `'a'`) are handled the same way.

### 2. Character Processing:
- The program checks if each character in the string is an alphabet letter using the `isalpha()` function.

- It compares each letter to the vowels `a, e, i, o, u` to increment the `vowels` counter.

- If the character is not a vowel and is an alphabet letter, it is considered a consonant, and the `consonants` counter is incremented.

### 3. Output:
- The program prints out the total number of vowels and consonants in the string.


---
## 🖼️ Sample Output:
### Example 1 - Input: `"Hello World!"`:
```yaml
Vowels: 3, Consonants: 7
```

### Example 2 - Input: `"Programming is Fun!"`:
```yaml
Vowels: 6, Consonants: 10
```
