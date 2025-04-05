# 🎮 Guess the Number Game (C Program)

This program implements a simple **Guess the Number** game, where the computer randomly selects a number between 1 and 100, and the user has to guess it. The game gives feedback whether the guess is too high, too low, or correct.

---

## 🧠 Problem Statement

The goal of this program is for the user to **guess** a randomly selected number between `1` and `100`. After each guess, the program will inform the user if their guess was too high or too low until the user guesses correctly.

---

## ⚙️ Logic & Approach

1. The program uses the **rand()** function to generate a random number between 1 and 100.
2. The user is asked to input their guess, and the program will check if the guess is higher, lower, or equal to the random number.
3. The program keeps track of the number of attempts and notifies the user once they correctly guess the number.
4. The program runs in a loop until the user guesses the correct number.

---

## 💻 Code

```c
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    int number, guess, attempts = 0;

    srand(time(0));  // Initialize random seed
    number = rand() % 100 + 1;  // Generate random number between 1 and 100

    printf("Guess the number between 1 and 100!\n");

    do {
        printf("Enter your guess: ");
        scanf("%d", &guess);  // User input for guessing
        attempts++;  // Increment the number of attempts

        // Check if the guess is too high, too low, or correct
        if (guess > number) 
            printf("Too high!\n");
        else if (guess < number) 
            printf("Too low!\n");
        else 
            printf("Congratulations! You guessed it in %d attempts.\n", attempts);  // Correct guess
    } while (guess != number);

    return 0;
}
```
🧪 Sample Output
**Input:**

```
Enter your guess: 50
```

**Output:**

```
Too low!
```

**Input:**

```
Enter your guess: 75
```

**Output:**

```
Too high!
```

**Input:**

```
Enter your guess: 63
```

**Output:**

```
Congratulations! You guessed it in 3 attempts.
```
