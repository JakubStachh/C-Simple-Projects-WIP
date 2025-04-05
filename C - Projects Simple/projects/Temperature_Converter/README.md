# 🧭 Temperature Converter Program in C

This program allows users to convert temperatures between Celsius and Fahrenheit. The program provides two options: 
1. Convert Celsius to Fahrenheit.
2. Convert Fahrenheit to Celsius.

---

## ⚙️ Logic & Approach

1. **Celsius to Fahrenheit Conversion:**
   - The function **`celsiusToFahrenheit(double c)`** takes a temperature in Celsius (`c`) as input and returns the corresponding temperature in Fahrenheit using the formula:
     $$
     \text{Fahrenheit} = \left( \text{Celsius} \times \frac{9}{5} \right) + 32
     $$

2. **Fahrenheit to Celsius Conversion:**
   - The function **`fahrenheitToCelsius(double f)`** takes a temperature in Fahrenheit (`f`) as input and returns the corresponding temperature in Celsius using the formula:
     $$
     \text{Celsius} = \left( \text{Fahrenheit} - 32 \right) \times \frac{5}{9}
     $$

3. **Main Program:**
   - The program prompts the user to select between two conversion options.
   - Depending on the choice, the program asks for the temperature input and then calls the appropriate conversion function.
   - It displays the converted temperature.

---

## 💻 Code

```c
#include <stdio.h>

// Function to convert Celsius to Fahrenheit
double celsiusToFahrenheit(double c) {
    return c * 9/5 + 32;
}

// Function to convert Fahrenheit to Celsius
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

    // Process the conversion based on user choice
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
```

---
## 🧪 Sample Output
### Example 1: Celsius to Fahrenheit Conversion
 - **Input:**
```
Enter your choice (1 or 2): 1
Enter temperature in Celsius: 25
```
 - **Output:**
```
Converted: 77.00°F
```

### Example 2: Fahrenheit to Celsius Conversion
 - **Input:**
```
Enter your choice (1 or 2): 2
Enter temperature in Fahrenheit: 77
```
 - **Output:**
```
Converted: 25.00°C
```
