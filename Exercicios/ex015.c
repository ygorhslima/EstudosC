/*
15) Crie um programa que leia o número de dias trabalhados em um mês e mostre o
salário de um funcionário, sabendo que ele trabalha 8 horas por dia e ganha R$25
por hora trabalhada.
*/

#include <stdio.h>
#include <stdlib.h>
int main(){
    int dias_trabalhados_mes;
    printf("Número de dias trabalhados em um mês: ");
    scanf("%d", &dias_trabalhados_mes);
    
    float horas_por_dia = 8.0;
    float dinheiro_por_hora = 25.0;


    float salario = dias_trabalhados_mes * horas_por_dia * dinheiro_por_hora;

    printf("O salário do funcionário é: %d", salario);
    return 0;
}