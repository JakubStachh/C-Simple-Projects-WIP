# 📝 Simple Notepad Program in C

This C program implements a simple notepad that allows users to write text to a file and read text from a file.

---

## ⚙️ Logic & Approach

1. **Write to File:**
   - The function **`writeToFile()`** opens a file named **"notes.txt"** in write mode.
   - It prompts the user to enter text (up to 500 characters).
   - The entered text is written to the file using the **`fprintf()`** function.
   - After saving the text, the file is closed.

2. **Read from File:**
   - The function **`readFromFile()`** opens the file **"notes.txt"** in read mode.
   - It checks if the file exists. If it does, the function reads and prints the contents line by line.
   - If the file does not exist, it informs the user that no saved notes were found.

3. **Main Program:**
   - The program presents the user with two options: 
     1. Write to file.
     2. Read from file.
   - Based on the user's choice, the appropriate function is called.

---

## 💻 Code

```c
#include <stdio.h>
#include <stdlib.h>

// Function to write text to a file
void writeToFile() {
    FILE *file = fopen("notes.txt", "w");
    if (file == NULL) {
        printf("Error opening file.\n");
        return;
    }

    char text[500];
    printf("Enter text to save (max 500 characters):\n");
    getchar(); // Clear buffer
    fgets(text, sizeof(text), stdin);  // Read text from user
    fprintf(file, "%s", text);  // Write text to file
    fclose(file);  // Close the file
    printf("Text saved successfully.\n");
}

// Function to read text from a file
void readFromFile() {
    FILE *file = fopen("notes.txt", "r");
    if (file == NULL) {
        printf("No saved notes found.\n");
        return;
    }

    char text[500];
    printf("Saved text:\n");
    while (fgets(text, sizeof(text), file)) {
        printf("%s", text);  // Print content line by line
    }
    fclose(file);  // Close the file
}

int main() {
    int choice;

    printf("Simple Notepad\n");
    printf("1. Write to file\n");
    printf("2. Read from file\n");
    printf("Enter your choice: ");
    scanf("%d", &choice);

    // Perform the corresponding action based on user input
    if (choice == 1) writeToFile();
    else if (choice == 2) readFromFile();
    else printf("Invalid choice.\n");

    return 0;
}
```

---
## 🧪 Sample Output
### Example 1 - Write to File:

- **Input:**
```
Enter your choice: 1
Enter text to save (max 500 characters):
Hello, this is a note!
```

- **Output:
```
Text saved successfully.
```

### Example 2 - Read from File:

- **Input:**
```
Enter your choice: 2
```

- **Output:**
```
Hello, this is a note!
```
