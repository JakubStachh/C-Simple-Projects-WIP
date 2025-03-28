#include <iostream>
#include <vector>
using namespace std;

void mergeArrays(int arr1[], int arr2[], int m, int n) {
    int i = 0, j = 0;

    vector<int> mergedArray;
    while (i < m && j < n) {
        if (arr1[i] < arr2[j]) {
            mergedArray.push_back(arr1[i]);
            i++;
        } else {
            mergedArray.push_back(arr2[j]);
            j++;
        }
    }

    while (i < m) {
        mergedArray.push_back(arr1[i]);
        i++;
    }

    while (j < n) {
        mergedArray.push_back(arr2[j]);
        j++;
    }

    cout << "Merged array: ";
    for (int num : mergedArray) {
        cout << num << " ";
    }
    cout << endl;
}

int main() {
    int arr1[] = {1, 3, 5, 7};
    int arr2[] = {2, 4, 6, 8};
    int m = sizeof(arr1) / sizeof(arr1[0]);
    int n = sizeof(arr2) / sizeof(arr2[0]);

    mergeArrays(arr1, arr2, m, n);
    return 0;
}
