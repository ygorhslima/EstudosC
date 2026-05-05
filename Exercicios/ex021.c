/*
21) Faça um algoritmo que leia um determinado ano e mostre se ele é ou não
BISSEXTO.
*/

#include <stdio.h>
#include <stdlib.h>

int main()
{
    int ano;

    printf("Digite um ano: ");
    scanf("%d", &ano);

    // Lógica: divisível por 400 OU (divisível por 4 E não por 100)
    if ((ano % 400 == 0) || (ano % 4 == 0 && ano % 100 != 0))
    {
        printf("%d eh BISSEXTO.\n", ano);
    }
    else
    {
        printf("%d NAO eh bissexto.\n", ano);
    }

    return 0;
}