/*
56) Crie um programa que leia vários números pelo teclado e mostre no final o
somatório entre eles.
Obs: O programa será interrompido quando o número 1111 for digitado
*/
#include <stdio.h>
#include <stdlib.h>

int main(){
    int numero = 0;
    int soma = 0;

    while(numero != 1111){
        printf("digite um número [1111 para terminar o programa]: ");
        scanf("%d", &numero);
        
        if(numero == 1111){
            printf("terminando o programa\n\n");
            break;
        }
        
        soma += numero;
    }

    printf("A soma de todos os valores solicitados foi igual a: %d", soma);
    
    return 0;
}