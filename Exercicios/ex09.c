/*
9) Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$)
e mostre quantos dólares ela pode comprar. Considere US$1,00 = R$3,45.
*/
#include <stdio.h>
#include <stdlib.h>
int main(){
    float reais, dolar;
    float cotacao = 3.45;
    
    printf("Quando dinheiro você tem na carteira?: R$");
    scanf("%f",&reais);

    dolar = reais / cotacao;
    printf("Valor em dólares: US$ %.2f\n", dolar);
    return 0;
}