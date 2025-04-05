# Matrix Multiplication Program

## 📝 **Overview**

This C++ program performs matrix multiplication on two 2x2 matrices and displays the result. It multiplies two matrices, `A` and `B`, and stores the result in a third matrix `result`. The program uses a nested loop to calculate the product of matrices.

---

## 💻 **How the Program Works**

### **Steps**:
1. **Matrix Initialization**:
   - Two 2x2 matrices `A` and `B` are defined with values.
   
2. **Matrix Multiplication**:
   - The `multiplyMatrices()` function performs matrix multiplication. The function iterates over the rows of matrix `A` and the columns of matrix `B`, calculating the sum of the products of corresponding elements.
   
3. **Output**:
   - The resulting matrix is printed row by row.

---

## 🧑‍💻 **Code**:

```cpp
#include <iostream>
using namespace std;

void multiplyMatrices(int A[2][2], int B[2][2], int result[2][2]) {
    for (int i = 0; i < 2; i++) {
        for (int j = 0; j < 2; j++) {
            result[i][j] = 0;
            for (int k = 0; k < 2; k++) {
                result[i][j] += A[i][k] * B[k][j];
            }
        }
    }
}

int main() {
    int A[2][2] = {{1, 2}, {3, 4}};
    int B[2][2] = {{5, 6}, {7, 8}};
    int result[2][2];
    
    multiplyMatrices(A, B, result);

    cout << "Result of matrix multiplication: \n";
    for (int i = 0; i < 2; i++) {
        for (int j = 0; j < 2; j++) {
            cout << result[i][j] << " ";
        }
        cout << endl;
    }
    return 0;
}
```

---
## 🚀 How It Works:
### 1. Matrix Initialization:
- Two 2x2 matrices, `A` and `B`, are initialized with predefined values.

### 2. Matrix Multiplication:
- The `multiplyMatrices` function takes three arguments: two 2x2 matrices (`A`, `B`) and an empty result matrix (`result`).

- It performs the multiplication using the formula:

$$
\large \text{result}[i][j] = \sum_{k=0}^{n-1} A[i][k] \times B[k][j]
$$


​where i represents the row index of matrix A, j represents the column index of matrix B, and k is the index for the sum over the product.
##
### 3. Displaying the Result:
- The result of the matrix multiplication is displayed row by row using nested loops.

---
## 🖼️ Sample Output:
```rust
Result of matrix multiplication: 
19 22 
43 50
```
In the output:

   - The result matrix is calculated as:

$$
\large\text{result}[0][0] = (1 \times 5) + (2 \times 7) = 19
$$
$$
\large\text{result}[0][1] = (1 \times 6) + (2 \times 8) = 22
$$
$$
\large\text{result}[1][0] = (3 \times 5) + (4 \times 7) = 43
$$
$$
\large\text{result}[1][1] = (3 \times 6) + (4 \times 8) = 50
$$

