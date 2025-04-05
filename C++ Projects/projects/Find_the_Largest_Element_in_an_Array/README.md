# Find Maximum Element in Array

## 📝 **Overview**

This C++ program finds the **largest element** in a given array of integers. The program iterates through the array and keeps track of the maximum value encountered during the traversal.

---

## 💻 **Program Explanation**

### **Steps**:
1. **Input**: The program takes an array of integers, for example: `{3, 5, 7, 2, 8}`.
2. **Find Maximum**: The function `findMax()` loops through the array and finds the largest number.
3. **Output**: The program prints the largest number from the array.

---

## 🧑‍💻 **Code**:

```cpp
#include <iostream>

int findMax(int arr[], int n) {
    int maxVal = arr[0]; // Initialize maxVal as the first element of the array
    for (int i = 1; i < n; i++) { // Iterate over the array starting from the second element
        if (arr[i] > maxVal) maxVal = arr[i]; // Update maxVal if a larger element is found
    }
    return maxVal; // Return the largest element
}

int main() {
    int arr[] = {3, 5, 7, 2, 8}; // Sample array
    int n = sizeof(arr) / sizeof(arr[0]); // Calculate the size of the array
    std::cout << "Largest element: " << findMax(arr, n) << std::endl; // Print the largest element
    return 0;
}
```

---
## 🚀 How It Works:
### 1. The `findMax()` Function:
- **Input**: The function takes an array `(arr[])` and the size of the array (`n`) as input parameters.

- **Logic:**

- Initialize the variable `maxVal` to the first element of the array (`arr[0]`).

- Iterate through the array starting from the second element. For each element, check if it is greater than `maxVal`. If true, update `maxVal` to the current element.

- After iterating through all elements, return `maxVal` which holds the largest value in the array.

### 2. `Main` Function:
- The `main()` function initializes a sample array, calculates its size using `sizeof`, and calls `findMax()` to find and print the largest element.

---
## 🖼️ Sample Output:
### Example - Output for the array `{3, 5, 7, 2, 8}`:
```yaml
Largest element: 8
```
