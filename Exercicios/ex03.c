/*
3) Crie um programa que leia o nome e o salário de um funcionário, mostrando no
final uma mensagem.
Ex:
Nome do Funcionário: Maria do Carmo
Salário: 1850,45
O funcionário Maria do Carmo tem um salário de R$1850,45 em Junho.
*/

#include <stdio.h>
#include <stdlib.h>
int main(){
    char nome_funcionario[100];
    float salario;

    printf("Nome do Funcionário: ");
    scanf("%[^\n]", &nome_funcionario);

    printf("Salário: ");
    scanf("%f", &salario);

    printf("O funcionário %s tem um salário de R$%.2f em junho\n", nome_funcionario, salario);

    return 0;
}