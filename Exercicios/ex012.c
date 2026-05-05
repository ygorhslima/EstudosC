/*
12) Crie um programa que leia o preço de um produto, calcule e mostre o seu
PREÇO PROMOCIONAL, com 5% de desconto.
*/

#include <stdio.h>
#include <stdlib.h>
int main(){
    float preco;
    printf("Digite o preço do produto: R$");
    scanf("%f", &preco);

    float desconto = preco * 0.05;
    float preco_promocional = preco - desconto;
    
    printf("Preço original: R$%.2f\n", preco);
    printf("Desconto: %.2f\n", desconto);
    printf("O preço promocional (5%% de desconto): R$%.2f\n", preco_promocional);
    return 0;
}