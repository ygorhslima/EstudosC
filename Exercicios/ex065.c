/*
66) Escreva um programa que leia um número qualquer e mostre a tabuada desse
número, usando a estrutura “para”.
Ex: Digite um valor: 5
5 x 1 = 5
5 x 2 = 10
5 x 3 = 15 ...
*/
#include <stdio.h>
#include <stdlib.h>
int main()
{
    char resposta;
    int n;
    while (true)
    {
        printf("Digite um valor: ");
        scanf("%d", &n);
        for (int i = 1; i <= 10; i++)
        {
            printf("%d x %d = %d\n", n, i, n * i);
        }
        printf("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n\n");

        printf("quer continuar [S/N]: ");
        scanf(" %c", &resposta);
        if (resposta == 'N')
        {
            printf("encerrando o programa...\n");
            break;
        }
    }
    return 0;
}