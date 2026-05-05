/*
6) Faça um programa que leia um número inteiro e mostre o seu antecessor e seu
sucessor.
Ex:
Digite um número: 9
O antecessor de 9 é 8
O sucessor de 9 é 107
*/
#include <stdio.h>
#include <stdlib.h>

int main(){
    int n;
    printf("Digite um número: ");
    scanf("%d", &n);
    printf("O antecessor é %d", n-1);
    printf("O sucessor é %d", n+1);
    
    return 0;
}