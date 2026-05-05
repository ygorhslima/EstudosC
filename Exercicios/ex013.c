/*
13) Faça um algoritmo que leia o salário de um funcionário, calcule e mostre o
seu novo salário, com 15% de aumento.
*/

#include <stdio.h>
#include <stdlib.h>
int main(){
    float salario;
    printf("Digite o seu salário: ");
    scanf("%f", &salario);

    float novo_salario = salario + (salario * 0.015);
    printf("Seu novo salário será de %.2f\n", novo_salario);

    return 0;
}