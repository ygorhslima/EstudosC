#include <stdio.h>
#include <math.h>
/*Escreva um programa que receba dois números, calcule e apresente o resultado
do primeiro número elevado ao segundo.*/
int main(){
    float n1,n2;
    double total;
    
    printf("\ninforme o primeiro número: ");
    scanf("%f",&n1);
    printf("\ninforme o segundo número: ");
    scanf("%f",&n2);

    total = pow(n1,n2);
    
    printf("\n %.2f elevado ao %.2f é: %.2f", n1, n2, total);
    /*OBS: para compilar o código é preciso que no final utilize o -lm para compilar contando a biblioteca para o linker poder entender que precisamos do uso da biblioteca <math.h>*/
    return 0;
}