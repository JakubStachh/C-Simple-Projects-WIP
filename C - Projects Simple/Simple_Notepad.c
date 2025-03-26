#include <stdio.h>
#include <stdlib.h>

void writeToFile() {
    FILE *file = fopen("notes.txt", "w");
    if (file == NULL) {
        printf("Error opening file.\n");
        return;
    }

    char text[500];
    printf("Enter text to save (max 500 characters):\n");
    getchar(); // Clear buffer
    fgets(text, sizeof(text), stdin);
    fprintf(file, "%s", text);
    fclose(file);
    printf("Text saved successfully.\n");
}

void readFromFile() {
    FILE *file = fopen("notes.txt", "r");
    if (file == NULL) {
        printf("No saved notes found.\n");
        return;
    }

    char text[500];
    printf("Saved text:\n");
    while (fgets(text, sizeof(text), file)) {
        printf("%s", text);
    }
    fclose(file);
}

int main() {
    int choice;
    
    printf("Simple Notepad\n");
    printf("1. Write to file\n");
    printf("2. Read from file\n");
    printf("Enter your choice: ");
    scanf("%d", &choice);

    if (choice == 1) writeToFile();
    else if (choice == 2) readFromFile();
    else printf("Invalid choice.\n");

    return 0;
}
