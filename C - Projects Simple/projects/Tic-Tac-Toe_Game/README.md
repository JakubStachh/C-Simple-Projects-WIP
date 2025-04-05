# 🎮 Tic-Tac-Toe Game in C

This is a console-based **Tic-Tac-Toe** game for two players. The game board is a 3x3 grid, and the players take turns to mark spaces with either 'X' or 'O'. The game ends when one player wins or the game is a draw.

---

## ⚙️ Logic & Approach

1. **Game Board Representation:**
   - The board is represented by a 2D array of characters, initially filled with numbers ('1' to '9') to indicate the available positions.

2. **Player Turns:**
   - Players alternate between 'X' and 'O'. Player 'X' starts first.
   - Players choose a position (1-9) to make their move. The program checks if the position is valid (not already taken) and places the player's mark.

3. **Checking for a Winner:**
   - The game checks for a winner after every move:
     - A player wins if they have three marks in a row, either horizontally, vertically, or diagonally.

4. **Draw Condition:**
   - If all 9 positions are filled and there is no winner, the game is a draw.

5. **Input and Output:**
   - The game continuously prompts the current player for input, prints the board after each move, and displays the result (winner or draw).

---

## 💻 Code

```c
#include <stdio.h>

char board[3][3] = {{'1', '2', '3'}, {'4', '5', '6'}, {'7', '8', '9'}};  // The game board
char player = 'X';  // Player 'X' starts the game

// Function to print the board
void printBoard() {
    printf("\n");
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            printf(" %c ", board[i][j]);
            if (j < 2) printf("|");
        }
        if (i < 2) printf("\n---|---|---\n");
    }
    printf("\n");
}

// Function to check if there is a winner
int checkWin() {
    for (int i = 0; i < 3; i++) {
        // Check rows and columns
        if (board[i][0] == board[i][1] && board[i][1] == board[i][2]) return 1;
        if (board[0][i] == board[1][i] && board[1][i] == board[2][i]) return 1;
    }
    // Check diagonals
    if (board[0][0] == board[1][1] && board[1][1] == board[2][2]) return 1;
    if (board[0][2] == board[1][1] && board[1][1] == board[2][0]) return 1;
    return 0;
}

// Function to make a move for a player
void makeMove(int position) {
    int row = (position - 1) / 3;
    int col = (position - 1) % 3;

    // Check if the position is valid
    if (board[row][col] == 'X' || board[row][col] == 'O') {
        printf("Invalid move! Try again.\n");
    } else {
        board[row][col] = player;  // Place the player's mark
        player = (player == 'X') ? 'O' : 'X';  // Switch to the other player
    }
}

int main() {
    int move, turns = 0;

    // Main game loop
    while (1) {
        printBoard();  // Display the current board
        printf("Player %c, enter your move (1-9): ", player);
        scanf("%d", &move);  // Read the player's move

        makeMove(move);  // Make the move
        turns++;  // Increase the turn counter

        // Check if a player has won
        if (checkWin()) {
            printBoard();  // Display the board one last time
            printf("Player %c wins!\n", (player == 'X') ? 'O' : 'X');
            break;
        }
        
        // Check if the game is a draw (board is full)
        if (turns == 9) {
            printBoard();  // Display the board one last time
            printf("It's a draw!\n");
            break;
        }
    }

    return 0;
}
```

---
## 🧪 Sample Output
### Example 1: Player 'X' wins
 - **Input:**
```
Player X, enter your move (1-9): 1
Player O, enter your move (1-9): 5
Player X, enter your move (1-9): 2
Player O, enter your move (1-9): 6
Player X, enter your move (1-9): 3
```

 - **Output:**
```
Player X wins!
```

### Example 2: It's a Draw
 - **Input:**
```
Player X, enter your move (1-9): 1
Player O, enter your move (1-9): 2
Player X, enter your move (1-9): 3
Player O, enter your move (1-9): 4
Player X, enter your move (1-9): 5
Player O, enter your move (1-9): 6
Player X, enter your move (1-9): 7
Player O, enter your move (1-9): 8
Player X, enter your move (1-9): 9
```
 - **Output:**
```
It's a draw!
```
