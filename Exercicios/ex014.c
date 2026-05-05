/*
14) A locadora de carros precisa da sua ajuda para cobrar seus serviços. Escreva
um programa que pergunte a quantidade de Km percorridos por um carro alugado e a
quantidade de dias pelos quais ele foi alugado. Calcule o preço total a pagar,
sabendo que o carro custa R$90 por dia e R$0,20 por Km rodado.
*/

#include <stdio.h>
#include <stdlib.h>
int main()
{
    float quant_km;
    int dias;
    float preco_total;

    printf("Quantos Km percorridos pelo carro?: ");
    scanf("%f", &quant_km);

    printf("Quantos dias o carro será alugado?: ");
    scanf("%d", &dias);

    float custo_dias = dias * 90;
    float custo_km = quant_km * 0.20;

    preco_total = custo_dias + custo_km;
    printf("o preço total do carro será de R$%.2f\n", preco_total);

    return 0;
}