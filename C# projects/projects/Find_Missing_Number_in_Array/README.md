# Find Missing Number Program in C#

## 🧑‍💻 **Overview**

This program identifies the **missing number** in an array that contains all numbers from 1 to `n`, except for one missing number. The size of the array is `n-1` (because one number is missing).

The algorithm calculates the **expected sum** of the numbers from 1 to `n` using the formula:
$$
\large \text{totalSum} = \frac{n \times (n+1)}{2} \]
$$
Then, it compares the **actual sum** of the array and finds the difference, which gives the missing number.

---

## 💻 **Program Explanation**

1. **Main Method**:
   - The program defines an array `arr` of integers where one number is missing.
   - It calculates the total sum of numbers from 1 to `n` and compares it with the sum of elements in the array to find the missing number.
  
2. **FindMissingNumber Method**:
   - This method calculates the **expected sum** of numbers from 1 to `n` and subtracts the **actual sum** of the elements in the array, returning the missing number.

---

## 🧑‍💻 **Code:**

```csharp
using System;

namespace FindMissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 5, 6 };
            int n = 6; // The size of the array + 1

            Console.WriteLine("The missing number is: " + FindMissingNumber(arr, n));
        }

        static int FindMissingNumber(int[] arr, int n)
        {
            int totalSum = n * (n + 1) / 2;
            int arrSum = 0;

            foreach (int num in arr)
            {
                arrSum += num;
            }

            return totalSum - arrSum;
        }
    }
}
```

---
## 🚀 Example Run:
### Input:
- **Array**: `{ 1, 2, 4, 5, 6 }`
Size `n`: `6` (expected array length including the missing number)

- **Output:**
```
The missing number is: 3
```
### Input:
- **Array**: `{ 2, 3, 4, 6 }`
Size `n`: `5` (expected array length including the missing number)

- **Output:**
```
The missing number is: 1
```

---
## 🔍 Explanation:
In the first example, the array has all numbers from `1` to `6` except for `3`. The total sum of numbers from `1` to `6` is `21`. The sum of the elements in the array is `18`. The difference `21 - 18 = 3`, which is the missing number.


