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
