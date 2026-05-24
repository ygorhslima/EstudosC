/*
desenvolva um programa que leia quatro valores pelo teclado e guarde-os em um vetor, no final mostre
A) quantas vezes apareceu o valor 9
B) EM que posiçao foi digitado o primeiro valor 3
C) Quais foram os números pares
*/

#include <stdio.h>
#include <stdlib.h>
#define MAX 4
int main()
{
    int i;
    int vetor[MAX];
    int numero;
    int quantVezes9;

    for (i = 0; i < MAX; i++)
    {
        printf("Digite um número: ");
        scanf("%d", &numero);
        vetor[i] = numero;

        if(vetor[i] == 9){
            quantVezes9++;
        }
    }


    printf("Você digitou os valores: ");
    printf("(");
    for (i = 0; i < MAX; i++)
    {
        printf(" %d ", vetor[i]);
    }
    printf(")\n");

    printf("O valor 9 apareceu %d vezes\n", quantVezes9);
    for(i = 0; i < MAX;i++){
        if(vetor[i] == 3){
            printf("O valor %d apareceu na %d°a posição\n", vetor[i], i+1);
        }
    }
    return 0;
}