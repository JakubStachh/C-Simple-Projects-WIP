# 📝 C Program: Check if Two Strings are Anagrams

This C program checks if two input strings are anagrams of each other. An anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

## 🔑 Key Concepts:
1. **Case Insensitivity**: The program ensures case insensitivity by converting all characters to lowercase using the `tolower()` function.
2. **Character Counting**: It counts the frequency of each character in both strings using two arrays, `count1` and `count2`.
3. **Validation**: It compares the character counts for both strings. If they match, the strings are anagrams.

## 🧑‍💻 Program Explanation:

### 1. `areAnagrams()` Function:
- This function compares two input strings to check if they are anagrams.
- **Input**: Two strings, `str1` and `str2`.
- **Steps**:
  1. It first checks if the lengths of the two strings are the same. If they are not, the strings cannot be anagrams.
  2. It then counts the frequency of each character in both strings (converting each character to lowercase to handle case insensitivity).
  3. Finally, it compares the frequency arrays for both strings. If they are identical, the strings are anagrams.

### 2. `Main` Function:
- The main function prompts the user for two strings, calls the `areAnagrams()` function, and prints whether the strings are anagrams or not.

## 💻 Code:

```c
#include <stdio.h>
#include <string.h>
#include <ctype.h>

#define SIZE 256

int areAnagrams(char *str1, char *str2) {
    int count1[SIZE] = {0}, count2[SIZE] = {0};

    if (strlen(str1) != strlen(str2)) return 0;

    for (int i = 0; str1[i] && str2[i]; i++) {
        count1[tolower(str1[i])]++;
        count2[tolower(str2[i])]++;
    }

    for (int i = 0; i < SIZE; i++) {
        if (count1[i] != count2[i]) return 0;
    }
    return 1;
}

int main() {
    char str1[100], str2[100];
    
    printf("Enter first string: ");
    scanf("%s", str1);
    
    printf("Enter second string: ");
    scanf("%s", str2);

    if (areAnagrams(str1, str2)) 
        printf("The strings are anagrams. ✅\n");
    else 
        printf("The strings are not anagrams. ❌\n");

    return 0;
}
```
##
🌟 Example:
**Input**:

```
Enter first string: listen
Enter second string: silent
```
**Output**:
```
The strings are anagrams. ✅
```
