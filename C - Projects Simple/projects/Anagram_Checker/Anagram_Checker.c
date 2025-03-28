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
        printf("The strings are anagrams.\n");
    else 
        printf("The strings are not anagrams.\n");

    return 0;
}
