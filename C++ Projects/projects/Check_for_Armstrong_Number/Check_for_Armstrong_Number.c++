#include <iostream>
#include <cmath>

bool isArmstrong(int num) {
    int sum = 0, temp = num, digits = 0;
    
    while (temp) {
        digits++;
        temp /= 10;
    }

    temp = num;
    while (temp) {
        sum += pow(temp % 10, digits);
        temp /= 10;
    }

    return sum == num;
}

int main() {
    int num = 153;
    std::cout << num << (isArmstrong(num) ? " is an Armstrong number" : " is not an Armstrong number") << std::endl;
    return 0;
}
