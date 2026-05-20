#include <stdio.h>
#include <stdlib.h>

// tamanho máximo do vetor
#define MAX 8

int main()
{
    int vetor[MAX];
    int i;

    printf("Adicionando valores para o vetor: ");
    for (i = 0; i < MAX; i++)
    {
        vetor[i] = 999;
    }

    printf("\n=============RESULTADO=============\n");
    printf("[");
    for (i = 0; i < MAX; i++){
        printf(" %d ", vetor[i]);
    }
    printf("]\n");

    return 0;
}