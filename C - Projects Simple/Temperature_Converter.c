#include <stdio.h>

double celsiusToFahrenheit(double c) {
    return c * 9/5 + 32;
}

double fahrenheitToCelsius(double f) {
    return (f - 32) * 5/9;
}

int main() {
    int choice;
    double temp, converted;

    printf("Temperature Converter:\n");
    printf("1. Celsius to Fahrenheit\n");
    printf("2. Fahrenheit to Celsius\n");
    printf("Enter your choice (1 or 2): ");
    scanf("%d", &choice);

    if (choice == 1) {
        printf("Enter temperature in Celsius: ");
        scanf("%lf", &temp);
        converted = celsiusToFahrenheit(temp);
        printf("Converted: %.2lf°F\n", converted);
    } else if (choice == 2) {
        printf("Enter temperature in Fahrenheit: ");
        scanf("%lf", &temp);
        converted = fahrenheitToCelsius(temp);
        printf("Converted: %.2lf°C\n", converted);
    } else {
        printf("Invalid choice.\n");
    }

    return 0;
}
