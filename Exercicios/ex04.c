/*
4) Desenvolva um algoritmo que leia dois números inteiros e mostre o somatório
entre eles.
Ex:
Digite um valor: 8
Digite outro valor: 5
A soma entre 8 e 5 é igual a 13.
*/
#include <stdio.h>
#include <stdlib.h>

int main(){
    int n1, n2, soma;
    
    printf("Digite um valor: ");
    scanf("%d", &n1);

    printf("Digite outro valor: ");
    scanf("%d", &n2);

    soma = n1 + n2;

    printf("A soma entre %d e %d é igual a %d\n", n1,n2,soma);
    return 0;
}