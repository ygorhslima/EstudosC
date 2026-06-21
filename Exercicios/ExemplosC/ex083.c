/*
83) [DESAFIO] Crie uma lógica que preencha um vetor de 20 posições com números
aleatórios (entre 0 e 99) gerados pelo computador. Logo em seguida, mostre os
números gerados e depois coloque o vetor em ordem crescente, mostrando no final
os valores ordenados.
*/
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define TAMANHO_MAX_VETOR 20

void ordenarVetor(int vet[], int tamanho);

int main()
{
    int vetor[TAMANHO_MAX_VETOR];
    int computador = 0;
    int i;
    srand(time(NULL));

    for (i = 0; i < TAMANHO_MAX_VETOR; i++)
    {
        computador = rand() % 99 + 1;
        vetor[i] = computador;
    }

    printf("[");
    for (i = 0; i < TAMANHO_MAX_VETOR; i++)
    {
        printf(" %d ", vetor[i]);
    }
    printf("]\n");

    ordenarVetor(vetor, TAMANHO_MAX_VETOR);

    printf("Vetor ordenado de forma crescente:\n[");
    for (i = 0; i < TAMANHO_MAX_VETOR; i++)
    {
        printf(" %d ", vetor[i]);
    }
    printf("]\n");

    return 0;
}

void ordenarVetor(int vet[], int tamanho)
{
    int i, j, auxiliar;

    for (i = 0; i < tamanho - 1; i++)
    {
        for (j = 0; j < tamanho - i - 1; j++)
        {
            if (vet[j] > vet[j + 1])
            {
                auxiliar = vet[j];
                vet[j] = vet[j + 1];
                vet[j + 1] = auxiliar;
            }
        }
    }
}