# Second Largest Element in Array

## 📝 **Overview**

This C++ program finds the **second largest** element in an array of integers. The program iterates through the array once, tracking both the largest and second largest elements efficiently.

---

## 💻 **Program Explanation**

### **Steps**:

1. **Input**: The program takes an array of integers.

2. **Find Second Largest Element**: 
   - It initializes two variables, `first` and `second`, both set to `INT_MIN` to represent the smallest possible value.
   - It iterates through the array, updating the `first` and `second` variables to track the largest and second largest values.

3. **Output**: The program prints the second largest element.

---

## 🧑‍💻 **Code**:

```cpp
#include <iostream>
#include <climits>

int secondLargest(int arr[], int n) {
    int first = INT_MIN, second = INT_MIN;
    for (int i = 0; i < n; i++) {
        if (arr[i] > first) {
            second = first;
            first = arr[i];
        } else if (arr[i] > second && arr[i] != first) {
            second = arr[i];
        }
    }
    return second;
}

int main() {
    int arr[] = {12, 35, 1, 10, 34, 1}; // Sample array
    int n = sizeof(arr) / sizeof(arr[0]); // Calculate array size
    std::cout << "Second largest element: " << secondLargest(arr, n) << std::endl;
    return 0;
}
```

---
## 🚀 How It Works:
### 1. The secondLargest() Function:
- **Input**: The function accepts an array `arr[]` and its size n.

- **Logic:**

   - The function initializes `first` and `second` to `INT_MIN`, which is the smallest possible integer value.

   - It iterates through the array and updates `first` and `second` to keep track of the largest and second largest elements.

      - If the current element is greater than `first`, it updates `second` to the previous `first` and sets `first` to the current element.

      - If the current element is greater than `second` but not equal to `first`, it updates `second`.

- **Output**: After traversing the array, it returns the second largest value.

### 2. `Main` Function:
- The `main()` function initializes an example array `arr[]`, calculates its size `n`, and calls the `secondLargest()` function to find and print the second largest element.


---
## 🖼️ Sample Output:
### Example - Output for the array `{12, 35, 1, 10, 34, 1}`:
```sql
Second largest element: 34
```
