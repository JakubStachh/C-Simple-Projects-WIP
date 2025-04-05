# 🔁 Duplicate Finder in C

This program finds and displays the **duplicate elements** present in an array of integers.

---

## 🧠 What It Does

- Takes an integer array.
- Compares each element with every other element ahead of it.
- If a match is found, it's printed as a duplicate (only once per value).

---

## 💻 Code:

```c
#include <stdio.h>

void findDuplicates(int arr[], int size) {
    printf("Duplicate elements: ");
    for (int i = 0; i < size - 1; i++) {
        for (int j = i + 1; j < size; j++) {
            if (arr[i] == arr[j]) {
                printf("%d ", arr[i]);
                break;
            }
        }
    }
    printf("\n");
}

int main() {
    int arr[] = {1, 2, 3, 4, 5, 2, 3, 6};
    int size = sizeof(arr) / sizeof(arr[0]);

    findDuplicates(arr, size);
    return 0;
}
```

---
## 🧪 Sample Output
```
Duplicate elements: 2 3
```
