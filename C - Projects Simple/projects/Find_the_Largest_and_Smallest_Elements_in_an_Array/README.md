# 📊 Find Minimum and Maximum in an Array (C Program)

This simple C program finds the **minimum** and **maximum** values in an array using a single traversal with the help of pointers.

---

## 🔍 What the Program Does

- Takes a predefined array of integers.
- Traverses the array once to:
  - 🟢 Identify the **smallest element**.
  - 🔴 Identify the **largest element**.
- Prints both the values.

---

## 🧠 How It Works

### 🔧 `findMinMax()` Function:
- **Parameters**:
  - `arr[]` – input array
  - `size` – number of elements
  - `*min`, `*max` – pointers to store results
- **Logic**:
  1. Initialize both `*min` and `*max` to the first element.
  2. Loop through the array:
     - If current element > `*max`, update `*max`.
     - If current element < `*min`, update `*min`.

---

## 💻 Code:

```c
#include <stdio.h>

void findMinMax(int arr[], int size, int *min, int *max) {
    *min = *max = arr[0];
    for (int i = 1; i < size; i++) {
        if (arr[i] > *max) *max = arr[i];
        if (arr[i] < *min) *min = arr[i];
    }
}

int main() {
    int arr[] = {10, 2, 5, 8, 1, 3};
    int size = sizeof(arr) / sizeof(arr[0]);
    int min, max;

    findMinMax(arr, size, &min, &max);
    printf("Min: %d, Max: %d\n", min, max);
    return 0;
}
```

---
## 🧪 Sample Output:
```
Min: 1, Max: 10
```
