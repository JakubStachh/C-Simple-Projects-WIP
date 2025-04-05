# 🔢 Prime Number Checker in C

## 🧮 What is a Prime Number?
A **prime number** is a number greater than 1 that has **no positive divisors other than 1 and itself**.

### ✅ Examples:
- `2`, `3`, `5`, `7`, `11`, `13` → Prime numbers  
- `4`, `6`, `8`, `9`, `10` → Not prime

---

## 📚 Program Explanation

### ✅ `isPrime(int n)` Function:
- **Checks if `n` is a prime number.**
- Returns `1` (true) if `n` is prime, `0` otherwise.
- Uses trial division up to `√n` for efficiency.

### 📥 `main()` Function:
- Asks the user for a number.
- Calls `isPrime()` to determine primality.
- Displays the result.

---

## 💻 Code

```c
#include <stdio.h>

int isPrime(int n) {
    if (n < 2) return 0;
    for (int i = 2; i * i <= n; i++) {
        if (n % i == 0) return 0;
    }
    return 1;
}

int main() {
    int num;
    printf("Enter a number: ");
    scanf("%d", &num);
    
    if (isPrime(num)) 
        printf("%d is prime.\n", num);
    else 
        printf("%d is not prime.\n", num);

    return 0;
}
```
---

## 🧪 Sample Run
**Input:**

```
Enter a number: 7
```

**Output:**

```
7 is prime.
```

---

## 🔍 How It Works
- The loop runs from `2` to `√n` (i.e., while `i * i <= n`).

- If any divisor is found in that range, the number is not prime.

- If none is found, it's prime.
