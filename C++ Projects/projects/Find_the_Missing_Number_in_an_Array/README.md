# Find Missing Number in Array

## 📝 **Overview**

This C++ program finds the **missing number** in a sequence of integers ranging from `1` to `n`, where `n` is the total number of integers in the sequence. The sequence contains all numbers from `1` to `n`, except one. The program calculates the missing number by leveraging the sum of the first `n` natural numbers.

---

## 💻 **Program Explanation**

### **Steps**:
1. **Input**: The program takes an array of integers where one number from the sequence `1` to `n` is missing.

2. **Find Missing Number**: It calculates the sum of the first `n` natural numbers using the formula: 
   $$
   \text{totalSum} = \frac{n \times (n + 1)}{2}
   $$
   It then calculates the sum of the numbers in the array (`arrSum`) and finds the difference between the two sums, which will give the missing number.

3. **Output**: The program prints the missing number.

---

## 🧑‍💻 **Code**:

```cpp
#include <iostream>
#include <vector>
using namespace std;

int findMissingNumber(const vector<int>& arr, int n) {
    int totalSum = n * (n + 1) / 2; // Formula for sum of first n natural numbers
    int arrSum = 0;
    
    for (int num : arr) { // Sum all elements in the array
        arrSum += num;
    }
    
    return totalSum - arrSum; // The missing number is the difference
}

int main() {
    vector<int> arr = {1, 2, 4, 5, 6}; // Sample array with a missing number
    int n = 6; // The total number of elements in the sequence (1 to n)
    
    cout << "Missing number: " << findMissingNumber(arr, n) << endl;
    return 0;
}
```

---
## 🚀 How It Works:
### 1. The `findMissingNumber()` Function:
- **Input**: The function takes an array `arr[]` of integers and an integer `n`, which represents the total number of elements in the sequence.

- **Logic:**

  - The total sum of the sequence from `1` to `n` is calculated using the formula:

$$
\large \text{totalSum} = \frac{n \times (n + 1)}{2}
$$
##

  - The function then iterates through the array and calculates the sum of the elements (`arrSum`).

  - The missing number is simply the difference between the total sum (`totalSum`) and the sum of the array (`arrSum`).

### 2. `Main` Function:
- The `main()` function initializes a sample array `arr[]` with a missing number, calculates the total number of elements (`n`), and calls the `findMissingNumber()` function to find and print the missing number.

---
## 🖼️ Sample Output:
### Example - Output for the array `{1, 2, 4, 5, 6}`:
```yaml
Missing number: 3
```
