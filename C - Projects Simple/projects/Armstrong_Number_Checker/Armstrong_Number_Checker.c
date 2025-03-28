#include <stdio.h>
#include <math.h>

int isArmstrong(int num) {
    int sum = 0, temp = num, digits = 0;
    
    while (temp) {  
        temp /= 10;
        digits++;
    }

    temp = num;
    while (temp) {
        sum += pow(temp % 10, digits);
        temp /= 10;
    }

    return sum == num;
}

int main() {
    int num;
    printf("Enter a number: ");
    scanf("%d", &num);

    if (isArmstrong(num)) 
        printf("%d is an Armstrong number.\n", num);
    else 
        printf("%d is not an Armstrong number.\n", num);

    return 0;
}
