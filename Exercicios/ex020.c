/*
20) Desenvolva um programa que leia um número inteiro e mostre se ele é PAR ou
ÍMPAR.
*/

#include <stdio.h>
#include <stdlib.h>

int main(){
    int n;
    printf("Digite um número: ");
    scanf("%d", &n);

    if(n % 2 == 0){
        printf("ele é PAR\n");
    }else{
        printf("ele é IMPAR\n");
    }
    return 0;
}