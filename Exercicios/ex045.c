/*
Faça um programa que leia 7 números inteiros e no final mostre o somatório
entre eles.
*/
#include <stdio.h>
#include <stdlib.h>
int main()
{
    int valor, soma;
    for (int i = 1; i <= 7; i++)
    {
        printf("Digite o °%d valor: ", i);
        scanf("%d", &valor);
        soma += valor;
    }
    printf("o somatório de todos os valores foi %d\n", soma);
    return 0;
}