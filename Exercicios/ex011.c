/*
11) Desenvolva uma lógica que leia os valores de A, B e C de uma equação do
segundo grau e mostre o valor de Delta.
*/
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
    double A, B, C;

    printf("Valor de A: ");
    scanf("%lf", &A);

    printf("Valor de B: ");
    scanf("%lf", &B);

    printf("Valor de C: ");
    scanf("%lf", &C);

    double delta = pow(B, 2) - 4*A*C;

    printf("O valor de Delta é %lf\n", delta);

    return 0;
}