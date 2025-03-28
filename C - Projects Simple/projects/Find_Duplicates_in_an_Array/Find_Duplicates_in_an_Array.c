#include <stdio.h>

void findDuplicates(int arr[], int size) {
    printf("Duplicate elements: ");
    for (int i = 0; i < size - 1; i++) {
        for (int j = i + 1; j < size; j++) {
            if (arr[i] == arr[j]) {
                printf("%d ", arr[i]);
                break;
            }
        }
    }
    printf("\n");
}

int main() {
    int arr[] = {1, 2, 3, 4, 5, 2, 3, 6};
    int size = sizeof(arr) / sizeof(arr[0]);

    findDuplicates(arr, size);
    return 0;
}
