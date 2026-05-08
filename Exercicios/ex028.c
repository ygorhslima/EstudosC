/*
* 28) Faça um programa que leia a largura e o comprimento de um terreno
retangular, calculando e mostrando a sua área em m². O programa também
devemostrar a classificação desse terreno, de acordo com a lista abaixo:
- Abaixo de 100m² = TERRENO POPULAR
- Entre 100m² e 500m² = TERRENO MASTER
- Acima de 500m² = TERRENO VIP
 *
 */
#include <stdio.h>
#include <stdlib.h>

int main() {
    float largura, comprimento;

    printf("Largura: ");
    scanf("%f", &largura);

    printf("Comprimento: ");
    scanf("%f", &comprimento);

    float area = largura * comprimento;
    printf("Area: %.2fx%.2f = %.2f\n", largura, comprimento, area);
    if (area <= 100) {
        printf("Terreno popular\n");
    }else if (area > 100 && area < 500) {
        printf("Terreno master\n");
    }else if (area > 500) {
        printf("Terreno VIP\n");
    }

    return 0;
}