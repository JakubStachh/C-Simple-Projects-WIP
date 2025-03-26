#include <stdio.h>
#include <limits.h>

int findSecondLargest(int arr[], int size) {
    int first = INT_MIN, second = INT_MIN;

    for (int i = 0; i < size; i++) {
        if (arr[i] > first) {
            second = first;
            first = arr[i];
        } else if (arr[i] > second && arr[i] != first) {
            second = arr[i];
        }
    }

    return (second == INT_MIN) ? -1 : second;
}

int main() {
    int arr[] = {12, 35, 1, 10, 34, 1};
    int size = sizeof(arr) / sizeof(arr[0]);
    
    int secondLargest = findSecondLargest(arr, size);
    if (secondLargest == -1)
        printf("No second largest number found.\n");
    else
        printf("Second largest number is: %d\n", secondLargest);

    return 0;
}
