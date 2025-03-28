#include <iostream>

int reverseNumber(int num) {
    int rev = 0;
    while (num > 0) {
        rev = rev * 10 + num % 10;
        num /= 10;
    }
    return rev;
}

int main() {
    int num = 12345;
    std::cout << "Reversed number: " << reverseNumber(num) << std::endl;
    return 0;
}
