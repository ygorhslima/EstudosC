
/*76) Crie um programa que preencha automaticamente um vetor numérico com 7
números gerados aleatoriamente pelo computador e depois mostre os valores
gerados na tela
*/

#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#define MAX 10

int main(){
    int vetor[MAX];
    int i;
    srand(time(NULL));
    
    //adicionando os elementos
    for(i = 0; i < MAX; i++){
        int elemento = rand() % 10 + 1;
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