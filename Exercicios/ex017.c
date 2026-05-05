/*
17) Escreva um programa que pergunte a velocidade de um carro. Caso ultrapasse
80Km/h, exiba uma mensagem dizendo que o usuário foi multado. Nesse caso, exiba
o valor da multa, cobrando R$5 por cada Km acima da velocidade permitida.
*/
#include <stdio.h>
#include <stdlib.h>
int main()
{
    int velocidade_carro;
    const int LIMITE = 80;
    float multa;

    printf("qual é a velocidade do carro?: ");
    scanf("%d", &velocidade_carro);

    if (velocidade_carro > LIMITE)
    {
        multa = (velocidade_carro - 80) * 5;
        printf("MULTADO! você excedeu o limite que é de %dkm/h\n", LIMITE);
        printf("o valor da multa será de %.1f\n", multa);
        printf("cuidado com a segurança é importante, valorize sua vida!\n");
    }
    else
    {
        printf("Muito bem! continue nesta velocidade, boa corrida e cuidado com a segurança\n");
    }
    return 0;
}