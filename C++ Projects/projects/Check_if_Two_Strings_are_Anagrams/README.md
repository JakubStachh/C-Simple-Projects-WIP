# Anagram Checker in C++

## 📝 **Overview**

This C++ program checks if two strings are **anagrams** of each other. **Anagrams** are words or phrases that contain the same characters in the same frequency but may have a different order of characters.

For example:
- **"listen"** and **"silent"** are anagrams because they contain the same characters with the same frequencies.
- **"hello"** and **"world"** are not anagrams because their characters differ.

---

## 💻 **Program Explanation**

### **Steps**:
1. **Length Check**: First, it checks if the lengths of both strings are equal. If they are not, they cannot be anagrams.
2. **Sorting**: The program sorts both strings alphabetically.
3. **Comparison**: After sorting, if both strings are identical, then they are anagrams; otherwise, they are not.

---

## 🧑‍💻 **Code:**

```cpp
#include <iostream>
#include <algorithm>

bool areAnagrams(std::string str1, std::string str2) {
    if (str1.length() != str2.length()) return false;
    std::sort(str1.begin(), str1.end());
    std::sort(str2.begin(), str2.end());
    return str1 == str2;
}

int main() {
    std::string str1 = "listen", str2 = "silent";
    std::cout << (areAnagrams(str1, str2) ? "Anagrams" : "Not Anagrams") << std::endl;
    return 0;
}
```

---
## 🚀 How It Works:
### 1. Length Check:
- Before proceeding with any complex operations, the program checks whether the two strings have the same length. If the lengths differ, the strings cannot be anagrams, and the function returns `false`.

### 2. Sorting:
- The program uses the `std::sort` function to sort both strings in lexicographical order (alphabetically). Sorting is done because anagrams, when sorted, will look identical.

### 3. Comparison:
- Once the strings are sorted, the program compares the two sorted strings. If they are the same, it means the strings are anagrams; otherwise, they are not.

---
## 🖼️ Sample Output:
### Example 1 - Check for `"listen"` and `"silent"`:
```yaml
Anagrams
```

### Example 2 - Check for `"hello"` and `"world"`:
```mathematica
Not Anagrams
```
