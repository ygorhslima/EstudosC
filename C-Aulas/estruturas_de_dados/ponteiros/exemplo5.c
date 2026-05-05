/**ao criar um vetor, estaticamente, é necessário especificar qual o seu tamanho */

/**
 * - pode ocasionar desperdício de memória
 * - o vetor não pode aumentar de tamanho em tempo de execução
 * 
 */

 /*alocando um vetor dinamicamente*/
#include <stdio.h>
#include <stdlib.h>
int *vetor; 
int main(){
    /**<ponteiro> = (<cast>*) malloc(sizeof(<tipo>)*<tam>) */
    vetor = (int*)malloc(sizeof(int)*10);
    return 0;
 }