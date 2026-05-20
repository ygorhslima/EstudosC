#include <stdio.h>
#include <stdlib.h>

#define MAX 10

int main(){
    int vetor[MAX];
    int i;
    int elemento = 0;
    
    //adicionando os elementos
    for(i = 0; i < MAX; i++){
        elemento += 5;
        vetor[i] = elemento;
    }

    //mostrando os elementos
    printf("[");
    for(i = 0; i < MAX; i++){
        printf(" %d", vetor[i]);
    }
    printf("]\n");
    return 0;
}