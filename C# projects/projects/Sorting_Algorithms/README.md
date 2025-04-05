# Bubble Sort Algorithm in C#

## 🧑‍💻 **Overview**

This C# program demonstrates the **Bubble Sort** algorithm, a simple sorting algorithm that repeatedly steps through the list, compares adjacent elements, and swaps them if they are in the wrong order. The process is repeated until the list is sorted.

---

## 💻 **Program Explanation**

1. **Input**: 
   - The program defines an unsorted array `arr` with integer values.
   - It first prints the unsorted array.
   
2. **Bubble Sort Logic**:
   - The `BubbleSort` method performs the sorting using the bubble sort algorithm.
   - It iterates through the array, comparing each element with its adjacent element and swapping them if the current element is greater than the next element.

3. **Output**:
   - The program prints the array before and after sorting.

---

## 🧑‍💻 **Code:**

```csharp
using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Before sorting:");
            PrintArray(arr);

            BubbleSort(arr);

            Console.WriteLine("After Bubble Sort:");
            PrintArray(arr);
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
```

---
## 🚀 Example Run:
### Input/Output Example 1:
```
Before sorting:
64 34 25 12 22 11 90 

After Bubble Sort:
11 12 22 25 34 64 90
```

---
## 🔍 Explanation:
### Before Sorting:

- The program prints the array `[64, 34, 25, 12, 22, 11, 90]` before applying the bubble sort algorithm.

### Bubble Sort Process:

- **First Pass**: Compares adjacent elements and swaps them if necessary. The largest element "bubbles up" to the end of the array.

- **Subsequent Passes**: Continue this process, reducing the number of elements to be compared as the largest elements are already in place.

### After Sorting:

- After the sorting process, the array is printed in ascending order: `[11, 12, 22, 25, 34, 64, 90]`.
