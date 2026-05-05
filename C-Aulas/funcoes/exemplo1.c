#include <stdio.h>

void soma(){
    float num1, num2, soma;
    printf("digite um número: ");
    scanf("%f",&num1);
    printf("digite outro número: ");
    scanf("%f",&num2);
    soma = num1 + num2;
    printf("A soma é %.2f\n", soma);
}

int main(){
    soma();
    return 0;
}