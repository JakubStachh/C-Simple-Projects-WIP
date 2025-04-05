# 📇 Contact Management System in C

A simple **Contact List Program** built in C to **add**, **view**, and **delete** contacts using a structured approach.

---

## 🔧 Features

- ✅ Add new contacts  
- 📋 View all saved contacts  
- ❌ Delete existing contacts  
- 🚫 Limit up to 100 contacts (as defined by `MAX_CONTACTS`)

---

## 🧱 Data Structure

The program uses a `struct` called `Contact` to store each person's information:

```c
typedef struct {
    char firstName[50];
    char lastName[50];
    char phone[20];
} Contact;
```
All contacts are stored in an array:
```
Contact contacts[MAX_CONTACTS];
int contactCount = 0;
```

---
## 💻 Code
```c
#include <stdio.h>
#include <string.h>

#define MAX_CONTACTS 100

typedef struct {
    char firstName[50];
    char lastName[50];
    char phone[20];
} Contact;

Contact contacts[MAX_CONTACTS];
int contactCount = 0;

void addContact() {
    if (contactCount < MAX_CONTACTS) {
        printf("Enter first name: ");
        scanf("%s", contacts[contactCount].firstName);
        printf("Enter last name: ");
        scanf("%s", contacts[contactCount].lastName);
        printf("Enter phone number: ");
        scanf("%s", contacts[contactCount].phone);
        contactCount++;
        printf("Contact added successfully!\n");
    } else {
        printf("Contact list is full!\n");
    }
}

void viewContacts() {
    if (contactCount == 0) {
        printf("No contacts available.\n");
    } else {
        printf("Contact List:\n");
        for (int i = 0; i < contactCount; i++) {
            printf("%d. %s %s - %s\n", i + 1, contacts[i].firstName, contacts[i].lastName, contacts[i].phone);
        }
    }
}

void deleteContact() {
    if (contactCount == 0) {
        printf("No contacts to delete.\n");
        return;
    }

    int index;
    printf("Enter contact number to delete: ");
    scanf("%d", &index);

    if (index < 1 || index > contactCount) {
        printf("Invalid contact number.\n");
        return;
    }

    for (int i = index - 1; i < contactCount - 1; i++) {
        contacts[i] = contacts[i + 1];
    }
    contactCount--;
    printf("Contact deleted successfully.\n");
}

int main() {
    int choice;
    
    do {
        printf("\nContact List\n");
        printf("1. Add Contact\n");
        printf("2. View Contacts\n");
        printf("3. Delete Contact\n");
        printf("4. Exit\n");
        printf("Enter your choice: ");
        scanf("%d", &choice);

        switch (choice) {
            case 1: addContact(); break;
            case 2: viewContacts(); break;
            case 3: deleteContact(); break;
            case 4: printf("Goodbye!\n"); break;
            default: printf("Invalid choice.\n");
        }
    } while (choice != 4);

    return 0;
}
```

---
## 🧪 Sample Run

```
Contact List
1. Add Contact
2. View Contacts
3. Delete Contact
4. Exit
Enter your choice: 1
Enter first name: John
Enter last name: Doe
Enter phone number: 1234567890
Contact added successfully!

Contact List
1. Add Contact
2. View Contacts
3. Delete Contact
4. Exit
Enter your choice: 2
Contact List:
1. John Doe - 1234567890
```

---
## 📌 Notes
- The program limits the number of contacts to `100`. You can change `#define` `MAX_CONTACTS` to allow more.

- Input validation is minimal—can be enhanced with more checks (e.g., valid phone number format).

- Currently works in-memory only—no file storage included.
