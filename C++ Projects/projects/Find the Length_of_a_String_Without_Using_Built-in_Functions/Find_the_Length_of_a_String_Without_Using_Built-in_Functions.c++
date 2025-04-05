#include <iostream>

int stringLength(const std::string &str) {
    int length = 0;
    while (str[length] != '\0') {
        length++;
    }
    return length;
}

int main() {
    std::string str = "Hello, World!";
    std::cout << "Length of string: " << stringLength(str) << std::endl;
    return 0;
}
