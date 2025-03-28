#include <iostream>

bool isPrime(int num) {
    if (num <= 1) return false;
    for (int i = 2; i * i <= num; i++) {
        if (num % i == 0) return false;
    }
    return true;
}

int main() {
    int num = 17;
    std::cout << num << (isPrime(num) ? " is Prime" : " is not Prime") << std::endl;
    return 0;
}
