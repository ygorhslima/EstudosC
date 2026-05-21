/*
75) Crie um programa que preencha automaticamente (usando lógica, não apenas
atribuindo diretamente) um vetor numérico com 15 posições com os primeiros
elementos da sequência de Fibonacci:
*/

#include <stdio.h>
#include <stdlib.h>
#define MAX 15

int main()
{
    int i;
    int vetor[MAX];
    vetor[0] = 1;
    vetor[1] = 1;

    for (i = 2; i < MAX; i++)
    {
        vetor[i] = vetor[i - 1] + vetor[i - 2];
    }

    printf("[");
    for (i = 0; i < MAX; i++)
    {
        if(i == MAX - 1){
            printf("%d", vetor[i]);
        }else{
            printf("%d, ", vetor[i]);
        }
    }
    printf("]\n");
    return 0;
}