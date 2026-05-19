/*
Crie um programa que leia 6 números inteiros e no final mostre quantos deles são pares e quantos são ímpares.
*/

#include <stdio.h>
#include <stdlib.h>

int main()
{
    int valor, cont_pares, cont_impares;
    for (int i = 1; i <= 6; i++)
    {
        printf("Digite o °%d valor: ", i);
        scanf("%d", &valor);

        if (valor % 2 == 0)
        {
            cont_pares++;
        }
        if (valor % 2 == 1)
        {
            cont_impares++;
        }
    }
    printf("Você digitou %d valores pares\n", cont_pares);
    printf("Você digitou %d valores impares\n", cont_impares);
    return 0;
}