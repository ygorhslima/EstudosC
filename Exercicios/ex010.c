/*
10) Faça um algoritmo que leia a largura e altura de uma parede, calcule e
mostre a área a ser pintada e a quantidade de tinta necessária para o serviço,
sabendo que cada litro de tinta pinta uma área de 2metros quadrados.
*/
#include <stdio.h>
#include <stdlib.h>
int main()
{
    float largura, altura;

    printf("Largura: ");
    scanf("%f", &largura);

    printf("Altura: ");
    scanf("%f", &altura);

    float area = largura * altura;
    float litros = area / 2;
    
    printf("\n--- Resultado ---");
    printf("\nÁrea a ser pintada: %.2f m²", area);
    printf("\nQuantidade de tinta necessária: %.2f litros\n", litros);
    return 0;
}