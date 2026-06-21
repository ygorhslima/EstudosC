/*
79) Desenvolva um programa que leia 10 números inteiros e guarde-os em um vetor.
No final, mostre quais são os números pares que foram digitados e em que
posições eles estão armazenados.
*/

#include <stdio.h>
#include <stdlib.h>
#define MAX 10

int main(){
    int i;  
    int numero;
    int vetor[MAX];
    
    for(i = 0; i < MAX; i++){
        printf("digite um número: ");
        scanf("%d", &numero);
        vetor[i] = numero;        
    }

    printf("valores pares obtidos: \n");
    for(i = 0; i < MAX; i++){
        if(vetor[i] % 2 == 0){
            printf("O valor %d está na posição %d\n", vetor[i], i);
        }
    }

    return 0;
}