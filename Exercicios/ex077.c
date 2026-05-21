/*
77) Faça um programa que leia 7 nomes de pessoas e guarde-os em um vetor. No
final, mostre uma listagem com todos os nomes informados, na ordem inversa
daquela em que eles foram informados.
*/

#include <stdio.h>
#include <stdlib.h>

int main()
{
    char nome[7][50];
    int i;

    printf("Digite 7 nomes:\n");
    for(i = 0; i < 7; i++){
        printf("Nome %d: ", i + 1);
        scanf("%49s", nome[i]);
    }

    printf("\nListagem dos nomes na ordem inversa:\n");
    for(i = 6; i >= 0; i--){
        printf("%s\n", nome[i]);
    }
    
    return 0;
}