#include <stdio.h>
#include <stdbool.h>

void main() {
    int num;
    int counter = 2;
    bool isPrime = true;

    printf("Enter a number: ");
    scanf("%d", &num);

    while (counter <= num / 2) {
        if (num % counter == 0) {
            isPrime = false;
            break;
        }
        counter++;
    }

    if (isPrime && num > 1) {
        printf("This is a prime number.\n");
    } else {
        printf("Not a prime number.\n");
    }
}






