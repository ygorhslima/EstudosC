/*
62) Faça um programa usando a estrutura “faça enquanto” que leia a idade de
várias pessoas. A cada laço, você deverá perguntar para o usuário se ele quer ou
não continuar a digitar dados. No final, quando o usuário decidir parar, mostre
na tela:
a) Quantas idades foram digitadas
b) Qual é a média entre as idades digitadas
c) Quantas pessoas tem 21 anos ou mais
*/
#include <stdio.h>
#include <stdlib.h>
int main()
{
    int idade;
    int cont;
    int idades21OuMais;
    int somaIdades;
    char resultado;
    float mediaIdades;

    while (resultado != 'N')
    {
        printf("Digite uma idade: ");
        scanf("%d", &idade);
        somaIdades += idade;
        cont++;

        if (idade >= 21)
        {
            idades21OuMais++;
        }

        printf("Quer continuar [S/N]: ");
        scanf(" %c", &resultado);
        if (resultado == 'N')
        {
            printf("Analisando os dados...\n\n");
            break;
        }
    }
    
    mediaIdades = somaIdades / cont;
    printf("Foram %d idades digitadas\n", cont);
    printf("A média de idades digitadas foi %f\n", mediaIdades);
    printf("Quantidade de pessoas que tem 21 anos ou mais: %d\n\n", idades21OuMais);
    return 0;
}