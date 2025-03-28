#include <iostream>
#include <vector>
using namespace std;

int findMissingNumber(const vector<int>& arr, int n) {
    int totalSum = n * (n + 1) / 2;
    int arrSum = 0;
    
    for (int num : arr) {
        arrSum += num;
    }
    
    return totalSum - arrSum;
}

int main() {
    vector<int> arr = {1, 2, 4, 5, 6};
    int n = 6;
    
    cout << "Missing number: " << findMissingNumber(arr, n) << endl;
    return 0;
}
