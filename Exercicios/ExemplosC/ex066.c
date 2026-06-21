/*
66) Faça um programa usando a estrutura “para” que leia um número inteiro
positivo e mostre na tela uma contagem de 0 até o valor digitado:
Ex: Digite um valor: 9
Contagem: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, FIM!
*/

#include <stdio.h>
#include <stdlib.h>
int main(){
    int n;
    printf("Digite um valor: ");
    scanf("%d", &n);
    for(int i=0; i<=n; i++){
        printf(" %d", i);
    }
    printf(" ACABOU\n");
    return 0;
}