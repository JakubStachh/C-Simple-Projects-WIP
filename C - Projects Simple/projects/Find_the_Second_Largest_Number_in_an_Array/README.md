# 🔢 Find the Second Largest Number in an Array (C Program)

This program finds the **second largest number** in a given array of integers.

---

## 🧠 Problem Statement

Given an array of integers, we are tasked with finding the **second largest number** in the array.

### 🧾 Example:
Array: `[12, 35, 1, 10, 34, 1]`

- **Largest number**: `35`
- **Second largest number**: `34`

---

## ⚙️ Logic & Approach

To find the second largest number:
1. Traverse the array while keeping track of the **largest** and **second largest** values.
2. Update the **largest** value if a larger element is found and adjust the **second largest** accordingly.
3. If no second largest number exists (e.g., all elements are equal), return `-1`.

---

## 💻 Code

```c
#include <stdio.h>
#include <limits.h>

int findSecondLargest(int arr[], int size) {
    int first = INT_MIN, second = INT_MIN;

    for (int i = 0; i < size; i++) {
        if (arr[i] > first) {
            second = first;
            first = arr[i];
        } else if (arr[i] > second && arr[i] != first) {
            second = arr[i];
        }
    }

    return (second == INT_MIN) ? -1 : second;
}

int main() {
    int arr[] = {12, 35, 1, 10, 34, 1};
    int size = sizeof(arr) / sizeof(arr[0]);
    
    int secondLargest = findSecondLargest(arr, size);
    if (secondLargest == -1)
        printf("No second largest number found.\n");
    else
        printf("Second largest number is: %d\n", secondLargest);

    return 0;
}
```

---
## 🧪 Sample Output
**Input:**

```
Array: [12, 35, 1, 10, 34, 1]
```

**Output:**

```
Second largest number is: 34
```
