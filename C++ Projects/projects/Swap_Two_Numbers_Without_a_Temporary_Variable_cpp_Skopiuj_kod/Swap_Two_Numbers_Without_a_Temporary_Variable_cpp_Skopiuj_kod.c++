#include <iostream>

int main() {
    int a = 5, b = 10;
    a = a + b;
    b = a - b;
    a = a - b;
    
    std::cout << "After swapping: a = " << a << ", b = " << b << std::endl;
    return 0;
}
