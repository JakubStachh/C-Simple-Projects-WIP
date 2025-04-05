# Merge Sorted Arrays Program

## 📝 **Overview**

This C++ program merges two sorted arrays into a single sorted array. The program uses the two-pointer technique to efficiently merge the arrays while maintaining the order. The merged array is then printed.

---

## 💻 **How the Program Works**

### **Steps**:
1. **Array Initialization**:
   - Two sorted arrays `arr1` and `arr2` are defined with values.
   
2. **Merging Process**:
   - The `mergeArrays()` function takes two arrays `arr1`, `arr2`, and their respective sizes `m` and `n`.
   - Two indices `i` and `j` are used to traverse through the two arrays. At each step, the smaller element is added to the merged array.
   
3. **Output**:
   - The merged array is printed in sorted order.

---

## 🧑‍💻 **Code**:

```cpp
#include <iostream>
#include <vector>
using namespace std;

void mergeArrays(int arr1[], int arr2[], int m, int n) {
    int i = 0, j = 0;

    vector<int> mergedArray;
    while (i < m && j < n) {
        if (arr1[i] < arr2[j]) {
            mergedArray.push_back(arr1[i]);
            i++;
        } else {
            mergedArray.push_back(arr2[j]);
            j++;
        }
    }

    while (i < m) {
        mergedArray.push_back(arr1[i]);
        i++;
    }

    while (j < n) {
        mergedArray.push_back(arr2[j]);
        j++;
    }

    cout << "Merged array: ";
    for (int num : mergedArray) {
        cout << num << " ";
    }
    cout << endl;
}

int main() {
    int arr1[] = {1, 3, 5, 7};
    int arr2[] = {2, 4, 6, 8};
    int m = sizeof(arr1) / sizeof(arr1[0]);
    int n = sizeof(arr2) / sizeof(arr2[0]);

    mergeArrays(arr1, arr2, m, n);
    return 0;
}
```

---
## 🚀 How It Works:
### 1. Array Initialization:
- Two sorted arrays, `arr1` and `arr2`, are initialized with predefined values.

### 2. Merging Process:
- The `mergeArrays` function takes four parameters: `arr1`, `arr2`, `m` (the size of `arr1`), and `n` (the size of `arr2`).

- The function uses two indices, `i` and `j`, to traverse through `arr1` and `arr2` respectively.

- At each step, the smaller of `arr1[i]` or `arr2[j]` is added to the merged array, ensuring the order is preserved.

### 3. Displaying the Merged Array:
- Once all elements from both arrays have been processed, the merged array is displayed.


---
## 🖼️ Sample Output:
```php
Merged array: 1 2 3 4 5 6 7 8
```
**In the output:**
   - The elements from `arr1 = {1, 3, 5, 7}` and `arr2 = {2, 4, 6, 8}` are merged into a single sorted array:

```ini
mergedArray = {1, 2, 3, 4, 5, 6, 7, 8}
```
