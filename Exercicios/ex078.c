/*
78) Escreva um programa que leia 15 números e guarde-os em um vetor. No final,
mostre o vetor inteiro na tela e em seguida mostre em que posições foram
digitados valores que são múltiplos de 10.
*/
#include <stdio.h>
#include <stdlib.h>
#define TAM 15

int main()
{
    int i;
    int numero;
    int vetor[TAM];

    for (i = 0; i < TAM; i++)
    {
        printf("Digite um número: ");
        scanf("%d", &numero);
        vetor[i] = numero;
    }

    printf("[");
    for (i = 0; i < TAM; i++)
    {
        printf(" %d ", vetor[i]);
    }
    printf("]\n");

    printf("[ALERTA] Valores Múltiplos de 10 encontrados!\n");
    for (i = 0; i < TAM; i++)
    {
        if (vetor[i] % 10 == 0)
        {
            printf("O número %d foi digitado na posição: %d\n", vetor[i], i);
        }
    }

    return 0;
}