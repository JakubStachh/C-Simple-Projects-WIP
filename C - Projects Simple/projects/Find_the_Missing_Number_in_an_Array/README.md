# 🔍 Find the Missing Number in an Array (C Program)

This program finds the **one missing number** in a sequence of `n` natural numbers from `1` to `n`, where one number is missing.

---

## 🧠 Problem Statement

Given an array of size `n - 1` containing distinct numbers from `1` to `n`, **find the missing number**.

### 🧾 Example:
 ```
 Array: `[1, 2, 4, 5, 6]`  
 Range: `1` to `6`  
 Missing number = `3`
 ```
---

## ⚙️ Logic & Approach

We know the **sum of the first n natural numbers** is:

$$
\large \text{Sum} = \frac{n(n+1)}{2}
$$

Steps:
1. Calculate the expected sum of numbers from `1` to `n`.
2. Calculate the actual sum of the array elements.
3. The difference is the missing number.

---

## 💻 Code

```c
#include <stdio.h>

int findMissingNumber(int arr[], int n) {
    int expectedSum = n * (n + 1) / 2;
    int actualSum = 0;
    for (int i = 0; i < n - 1; i++) {
        actualSum += arr[i];
    }
    return expectedSum - actualSum;
}

int main() {
    int arr[] = {1, 2, 4, 5, 6}; // Missing 3
    int n = 6;
    printf("Missing number: %d\n", findMissingNumber(arr, n));
    return 0;
}
```

---
## 🧪 Sample Output
```
Missing number: 3
```
