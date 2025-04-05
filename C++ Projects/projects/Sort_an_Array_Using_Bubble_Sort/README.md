# Bubble Sort Program

## 📝 **Overview**

This C++ program implements the **Bubble Sort** algorithm, which is used to sort an array in ascending order. The program repeatedly compares adjacent elements and swaps them if they are in the wrong order, ensuring that the largest elements "bubble up" to the end of the array after each pass.

---

## 💻 **How the Program Works**

### **Steps**:
1. **Input**:
   - The program starts with an unsorted integer array.

2. **Bubble Sort Process**:
   - The `bubbleSort()` function is implemented, where it compares adjacent elements and swaps them if they are in the wrong order.

3. **Output**:
   - After sorting, the program prints the sorted array to the console.

---

## 🧑‍💻 **Code**:

```cpp
#include <iostream>

void bubbleSort(int arr[], int n) {
    for (int i = 0; i < n - 1; i++) {
        for (int j = 0; j < n - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                std::swap(arr[j], arr[j + 1]);
            }
        }
    }
}

int main() {
    int arr[] = {64, 25, 12, 22, 11};
    int n = sizeof(arr) / sizeof(arr[0]);

    bubbleSort(arr, n);

    std::cout << "Sorted array: ";
    for (int i = 0; i < n; i++) {
        std::cout << arr[i] << " ";
    }
    std::cout << std::endl;

    return 0;
}
```

---
## 🚀 How It Works:
### 1. Input Array:
- The program initializes an unsorted array, for example: `{64, 25, 12, 22, 11}`.

### 2. Bubble Sort:
- The `bubbleSort()` function uses two nested loops:

    - The outer loop controls the number of passes.

    - The inner loop compares each pair of adjacent elements and swaps them if necessary.

    - After each pass, the largest unsorted element moves to its correct position at the end of the array.

### 3. Output the Sorted Array:
After sorting, the program prints the sorted array to the console.

---
## 🖼️ Sample Output:
```php
Sorted array: 11 12 22 25 64 
```
### In the output:

   - The array `{64, 25, 12, 22, 11}` is sorted in ascending order to `{11, 12, 22, 25, 64}`.
