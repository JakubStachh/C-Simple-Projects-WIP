# Armstrong Number Check in C

## 📝 **Armstrong Number Definition**
An **Armstrong number** (also known as a narcissistic number or pluperfect number) is a number that is equal to the sum of its own digits, each raised to the power of the number of digits. For example:
### - 153 is an Armstrong number because:
  
  $$ 
  \large 1^3 + 5^3 + 3^3 = 153 
  $$
  ##
  
### - 370 is an Armstrong number because:
  
  $$ 
  \large 3^3 + 7^3 + 0^3 = 370 
  $$
  ##
  
## 📚 **Program Explanation**

1. **`isArmstrong()` Function:**
   - **Input**: A number `num`.
   - **Process**: 
     1. The function first calculates how many digits the number has by dividing it by 10 repeatedly.
     2. Then it calculates the sum of the digits, each raised to the power of the number of digits.
     3. Finally, it compares the calculated sum with the original number to determine if it is an Armstrong number.
   - **Output**: It returns `1` if the number is an Armstrong number, otherwise `0`.

2. **`main()` Function:**
   - It takes user input and calls the `isArmstrong()` function.
   - Based on the result, it prints whether the number is an Armstrong number or not.

## 🧑‍💻 **Code:**

```c
#include <stdio.h>
#include <math.h>

// Function to check if a number is an Armstrong number
int isArmstrong(int num) {
    int sum = 0, temp = num, digits = 0;
    
    // Calculate the number of digits in the number
    while (temp) {  
        temp /= 10;
        digits++;
    }

    // Reset temp to the original number
    temp = num;

    // Sum the digits raised to the power of 'digits'
    while (temp) {
        sum += pow(temp % 10, digits); // temp % 10 gives the last digit
        temp /= 10;  // Remove the last digit
    }

    // Check if the sum of digits raised to the power equals the original number
    return sum == num;
}

int main() {
    int num;

    // User input
    printf("Enter a number: ");
    scanf("%d", &num);

    // Check if the number is an Armstrong number
    if (isArmstrong(num)) 
        printf("%d is an Armstrong number.\n", num);  // Armstrong number
    else 
        printf("%d is not an Armstrong number.\n", num);  // Not an Armstrong number

    return 0;
}
```
## 🚀 Example Run:
**Input:**
```
Enter a number: 153
```

**Output**:
```
153 is an Armstrong number.
```

**Input**:
```
Enter a number: 123
```

**Output**:
```
123 is not an Armstrong number.
```
## ⚡ How the Program Works:
 - The user inputs a number, and the program calculates the sum of each digit raised to the power of the number of digits.

 - For example, for the number 153:

 $$ 
\large 1^3 + 5^3 + 3^3 \text{ = 153 so it is an Armstrong number.}
 $$
 ##
 - The function checks if the sum equals the original number and prints the appropriate message.
