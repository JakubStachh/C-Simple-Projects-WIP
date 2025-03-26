#include <stdio.h>

// Recursive approach (inefficient for large n)
int fibonacciRecursive(int n) {
    if (n <= 1) return n;
    return fibonacciRecursive(n - 1) + fibonacciRecursive(n - 2);
}

// Iterative approach (efficient)
int fibonacciIterative(int n) {
    if (n <= 1) return n;
    int a = 0, b = 1, c;
    for (int i = 2; i <= n; i++) {
        c = a + b;
        a = b;
        b = c;
    }
    return c;
}

int main() {
    int n;
    printf("Enter position: ");
    scanf("%d", &n);
    
    printf("Fibonacci (Recursive): %d\n", fibonacciRecursive(n));
    printf("Fibonacci (Iterative): %d\n", fibonacciIterative(n));

    return 0;
}
