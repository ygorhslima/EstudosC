/*
74) Crie um programa que preencha automaticamente (usando lógica, não apenas
atribuindo diretamente) um vetor numérico com 10 posições, conforme abaixo:
*/

#include <stdio.h>
#include <stdlib.h>
#define MAX 10

int main()
{
    int vetor[MAX];
    int i;
    int elemento;

    for (i = 0; i < MAX; i++)
    {
        if(i % 2 == 0){
            vetor[i] = 5;
        }else{
            vetor[i] = 3;
        }
    }

    printf("[");
    for (i = 0; i < MAX; i++){
        printf(" %d ", vetor[i]);
    }
    printf("]\n");

    return 0;
}