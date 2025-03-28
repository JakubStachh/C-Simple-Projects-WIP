#include <stdio.h>

int findMissingNumber(int arr[], int n) {
    int expectedSum = n * (n + 1) / 2;
    int actualSum = 0;
    for (int i = 0; i < n - 1; i++) {
        actualSum += arr[i];
    }
    return expectedSum - actualSum;
}

int main() {
    int arr[] = {1, 2, 4, 5, 6}; // Missing 3
    int n = 6;
    printf("Missing number: %d\n", findMissingNumber(arr, n));
    return 0;
}
