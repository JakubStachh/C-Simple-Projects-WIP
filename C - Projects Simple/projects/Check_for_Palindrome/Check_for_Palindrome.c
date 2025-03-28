#include <stdio.h>
#include <string.h>

// Check if a string is a palindrome
int isPalindromeString(char *str) {
    int left = 0, right = strlen(str) - 1;
    while (left < right) {
        if (str[left++] != str[right--]) return 0;
    }
    return 1;
}

// Check if a number is a palindrome
int isPalindromeNumber(int num) {
    int original = num, reversed = 0;
    while (num > 0) {
        reversed = reversed * 10 + (num % 10);
        num /= 10;
    }
    return original == reversed;
}

int main() {
    char str[] = "racecar";
    int num = 121;

    printf("Is '%s' a palindrome? %s\n", str, isPalindromeString(str) ? "Yes" : "No");
    printf("Is %d a palindrome? %s\n", num, isPalindromeNumber(num) ? "Yes" : "No");

    return 0;
}
