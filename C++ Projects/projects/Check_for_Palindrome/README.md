# Palindrome Checker in C++

## 📝 **Overview**

This C++ program checks if a given string is a **palindrome**. A **palindrome** is a word, phrase, number, or other sequence of characters that reads the same forward and backward (ignoring spaces, punctuation, and capitalization).

For example:
- **"madam"** is a palindrome because it reads the same from left to right and right to left.
- **"hello"** is not a palindrome.

---

## 💻 **Program Explanation**

### **Steps**:
1. **Two-pointer technique**: The program uses two pointers, `left` and `right`, to compare characters from the beginning and end of the string, progressively moving towards the center.
2. **Character Comparison**: If any characters don't match, it immediately returns `false` (not a palindrome).
3. **Return Result**: If all comparisons are successful, it returns `true`, indicating the string is a palindrome.

---

## 🧑‍💻 **Code:**

```cpp
#include <iostream>

bool isPalindrome(const std::string &str) {
    int left = 0, right = str.length() - 1;
    while (left < right) {
        if (str[left++] != str[right--]) return false;
    }
    return true;
}

int main() {
    std::string str = "madam";
    std::cout << (isPalindrome(str) ? "Palindrome" : "Not a Palindrome") << std::endl;
    return 0;
}
```

---
## 🚀 How It Works:
### 1. Two Pointers:
- The program initializes two indices: `left` starting at the beginning of the string and `right` starting at the end. It compares characters from both ends towards the center.

### 2. Compare Characters:
- For each pair of characters (left and right), if they are not equal, the function immediately returns `false`.

### 3. Progress Until Middle:
- If all pairs match, the `left` pointer moves rightwards and the `right` pointer moves leftwards, and this continues until the pointers meet in the middle.

### 4. Final Decision:
- If no mismatched characters are found, the function returns `true`, confirming the string is a palindrome.

- Otherwise, it returns `false`.

---
## 🖼️ Sample Output:
### Example 1 - Check for "madam":
```yaml
Palindrome
```

### Example 2 - Check for a non-palindrome string (e.g., `"hello"`):
```css
Not a Palindrome
```
