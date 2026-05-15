/*
desenvolva um programa que leia seis números inteiros e mostre a soma apenas daquelas que foram pares, se o valor digitado for impar, desconsidere-o
*/

#include <stdio.h>
#include <stdlib.h>
int main(){
    int cont;
    int soma;
    int num;
    for(int i = 0; i < 6; i++){
        printf("Digite um valor: ");
        scanf("%d", &num);
        if (num % 2 == 0){
            soma += num;
        }
        cont++;
    }
    printf("Você informou %d números PARES e a soma desses valores foi %d", cont, soma);
    return 0;
}