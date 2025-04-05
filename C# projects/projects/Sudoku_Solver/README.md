# Sudoku Solver in C#

## 🧑‍💻 **Overview**

This C# program solves a given Sudoku puzzle using a **backtracking algorithm**. The program recursively fills the Sudoku grid by checking for valid numbers to place in the empty cells, ensuring that the placement of numbers follows the Sudoku rules.

### **Sudoku Rules**:
- Each number from 1 to 9 must appear once per row, column, and 3x3 subgrid.

---

## 💻 **Program Explanation**

### **Steps**:
1. **Input**:
   - A partially filled Sudoku board is provided.
   - Empty cells are represented by `0`.

2. **Backtracking Approach**:
   - The program uses a backtracking algorithm to attempt filling the board. If a valid number is placed in a cell, it recursively tries to solve the board.
   - If a valid number cannot be placed in a cell, the program "backtracks" and tries a different number.

3. **Checking Validity**:
   - For each cell, the program checks if placing a number violates any Sudoku rule (row, column, or 3x3 subgrid).

4. **Output**:
   - If the board is solvable, it prints the solved Sudoku grid.
   - If no solution is found, it prints `"No solution exists."`.

---

## 🧑‍💻 **Code:**

```csharp
using System;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] board = {
                { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
                { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
                { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
                { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
                { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
                { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
                { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
                { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
                { 0, 0, 0, 0, 8, 0, 0, 7, 9 }
            };

            if (SolveSudoku(board))
            {
                PrintBoard(board);
            }
            else
            {
                Console.WriteLine("No solution exists.");
            }
        }

        static bool SolveSudoku(int[,] board)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row, col] == 0)
                    {
                        for (int num = 1; num <= 9; num++)
                        {
                            if (IsSafe(board, row, col, num))
                            {
                                board[row, col] = num;
                                if (SolveSudoku(board))
                                    return true;
                                board[row, col] = 0;
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        static bool IsSafe(int[,] board, int row, int col, int num)
        {
            // Check the row
            for (int i = 0; i < 9; i++)
                if (board[row, i] == num)
                    return false;

            // Check the column
            for (int i = 0; i < 9; i++)
                if (board[i, col] == num)
                    return false;

            // Check the 3x3 grid
            int startRow = row - row % 3;
            int startCol = col - col % 3;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (board[i + startRow, j + startCol] == num)
                        return false;

            return true;
        }

        static void PrintBoard(int[,] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
```

---
## 🚀 Example Run:
### Input/Output Example 1:
```yaml
Before solving:

5 3 0 0 7 0 0 0 0 
6 0 0 1 9 5 0 0 0 
0 9 8 0 0 0 0 6 0 
8 0 0 0 6 0 0 0 3 
4 0 0 8 0 3 0 0 1 
7 0 0 0 2 0 0 0 6 
0 6 0 0 0 0 2 8 0 
0 0 0 4 1 9 0 0 5 
0 0 0 0 8 0 0 7 9

After solving:

5 3 4 6 7 8 9 1 2 
6 7 2 1 9 5 3 4 8 
1 9 8 3 4 2 5 6 7 
8 5 9 7 6 1 4 2 3 
4 2 6 8 5 3 7 9 1 
7 1 3 9 2 4 8 5 6 
9 6 1 5 3 7 2 8 4 
2 8 7 4 1 9 6 3 5 
3 4 5 2 8 6 1 7 9
```

---
## 🔍 Explanation:
### Initial Puzzle:

- The given Sudoku puzzle has some pre-filled numbers and others left empty, represented as `0`.

### Backtracking Process:

- The `SolveSudoku` method tries filling the empty cells with numbers from 1 to 9, ensuring each number respects Sudoku's rules.

- If the program encounters a conflict, it backtracks and tries a different number.

### Solution:

- If the board is successfully filled, it prints the solved Sudoku grid, otherwise, it prints `"No solution exists."`.
