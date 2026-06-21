/*
* 26) Escreva um algoritmo que leia dois números inteiros e compare-os, mostrando
na tela uma das mensagens abaixo:
- O primeiro valor é o maior
- O segundo valor é o maior
- Não existe valor maior, os dois são iguais
 *
 *
 */

#include <stdio.h>
#include <stdlib.h>

int main() {
    int n1,n2;
    printf("Digite um número: ");
    scanf("%d", &n1);
    printf("Digite outro número: ");
    scanf("%d", &n2);

    if (n1 > n2) {
        printf("%d é maior que %d\n", n1, n2);
    }else if (n2 > n1) {
        printf("%d é maior que %d\n", n2, n1);
    }else {
        printf("Não existe valor maior, os dois são iguais\n");
    }

    return 0;
}