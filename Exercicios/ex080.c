/*
80) Faça um algoritmo que preencha um vetor de 30 posições com números entre 1 e
15 sorteados pelo computador. Depois disso, peça para o usuário digitar um
número (chave) e seu programa deve mostrar em que posições essa chave foi
encontrada. Mostre também quantas vezes a chave foi sorteada.
*/

#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#define MAX 30

int main()
{
    int vetor[MAX];
    int i;
    int computador;
    int chave;
    int contador;

    srand(time(NULL));
    for (i = 0; i < MAX; i++)
    {
        computador = rand() % 15 + 1;
        vetor[i] = computador;
    }

    printf("Digite um número chave para mostrar o valor desta posição: ");
    scanf("%d", &chave);
    for (i = 0; i < MAX; i++)
    {
        if (vetor[i] == chave)
        {
            printf("%d ", i);
            contador++;
        }
    }
    printf("A chave foi sorteada %d vezes.\n", contador);
    return 0;
}