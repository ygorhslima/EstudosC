#include <stdio.h>

/**Faça um programa que receba o valor de um depósito e o valor da taxa de juros, calcule e
apresente o valor do rendimento e o valor total (valor do depósito + valor do rendimento). */

int main(){
    float deposito, taxa, rendimento, total;
    
    printf("informe o valor de depósito: R$");
    scanf("%f",&deposito);
    printf("informe o valor da taxa de juros: ");
    scanf("%f",&taxa);

    rendimento = deposito * (taxa/100);
    total = deposito + rendimento;

    printf("o rendimento foi de R$%.2f\n",rendimento);
    printf("e o valor total foi de R$%.2f\n",total);
    return 0;
}