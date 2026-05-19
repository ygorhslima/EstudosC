/*
67) Crie um programa que leia sexo e peso de 8 pessoas, usando a estrutura
“para”. No final, mostre na tela:
a) Quantas mulheres foram cadastradas
b) Quantos homens pesam mais de 100Kg
c) A média de peso entre as mulheres
d) O maior peso entre os homens
*/
#include <stdio.h>
#include <stdlib.h>

int main()
{
    char resposta;
    char sexo;
    float peso;
    int quantMulheres = 0;
    int somaPeso = 0;
    int quantHomensMais100kg = 0;
    float mediaMulheres = 0;
    float maiorPesoHomem = -1;
    int cont;

    while (resposta != 'N')
    {
        printf("Sexo[M/F]: ");
        scanf(" %c", &sexo);
        printf("Peso: ");
        scanf("%f", &peso);

        if (sexo == 'M')
        {
            if (peso > 100)
            {
                quantHomensMais100kg++;
            }
            if (cont == 1 || peso > maiorPesoHomem)
            {
                maiorPesoHomem = peso;
            }
        }

        if (sexo == 'F')
        {
            somaPeso += peso;
            quantMulheres++;
        }

        cont++;

        printf("Quer continuar [S/N]: ");
        scanf(" %c", &resposta);
        if (resposta == 'N')
        {
            printf("Analisando os dados...\n\n");
            break;
        }
    }
    mediaMulheres = somaPeso / quantMulheres;
    printf("Quantidade de mulheres cadastradas: %d\n", quantMulheres);
    printf("Quantidade de homens que pesam mais de 100kg: %d\n", quantHomensMais100kg);
    printf("A média de peso entre as mulheres: %f\n", mediaMulheres);
    printf("O maior peso entre os homens foi de %f\n\n", maiorPesoHomem);
}