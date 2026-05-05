/*
5) Faça um programa que leia as duas notas de um aluno em uma matéria e mostre
na tela a sua média na disciplina.
Ex:
Nota 1: 4.5
Nota 2: 8.5
A média entre 4.5 e 8.5 é igual a 6.5
*/
#include <stdio.h>
#include <stdlib.h>
int main(){
    float n1,n2,media;
    printf("Nota 1: ");
    scanf("%f",&n1);

    printf("Nota 2: ");
    scanf("%f", &n2);

    media = (n1 + n2) / 2;

    printf("A média entre %.1f e %.1f é igual a %.1f\n", n1,n2,media);
    return 0;
}