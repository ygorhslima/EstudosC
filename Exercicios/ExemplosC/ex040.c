/*
Faça um programa que calcula a soma entre todos os números impares que são múltiplos de três e que se encontram no intervalo de 1 até 500
*/

#include <stdio.h>
#include <stdlib.h>
int main(){
    int soma = 0;
    int cont = 0; 
    for(int i = 1; i < 501; i+=2){
        if(i % 3 == 0){
            soma += i;
            cont++;
        }
    }
    printf("A soma de todos os %d valores solicitados é %d\n", cont, soma);
    return 0;
}