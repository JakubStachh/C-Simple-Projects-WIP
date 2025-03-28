#include <stdio.h>
#include <string.h>

int main() {
    char text[500], ch;
    int count = 0;

    printf("Enter a text (max 500 characters):\n");
    getchar(); // Clear buffer
    fgets(text, sizeof(text), stdin);

    printf("Enter a character to count: ");
    scanf(" %c", &ch);

    for (int i = 0; i < strlen(text); i++) {
        if (text[i] == ch) count++;
    }

    printf("The character '%c' appears %d times.\n", ch, count);
    return 0;
}
