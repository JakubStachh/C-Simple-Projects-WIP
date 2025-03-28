#include <iostream>
#include <cctype>

void countVowelsAndConsonants(const std::string &str) {
    int vowels = 0, consonants = 0;
    
    for (char c : str) {
        c = std::tolower(c);
        if (isalpha(c)) {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') {
                vowels++;
            } else {
                consonants++;
            }
        }
    }

    std::cout << "Vowels: " << vowels << ", Consonants: " << consonants << std::endl;
}

int main() {
    std::string str = "Hello World!";
    countVowelsAndConsonants(str);
    return 0;
}
