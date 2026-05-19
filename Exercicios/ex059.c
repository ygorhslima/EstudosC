/*
59) Crie um programa que leia o sexo e a idade de várias pessoas. O programa vai
perguntar se o usuário quer continuar ou não a cada pessoa. No final, mostre:
a) qual é a maior idade lida
b) quantos homens foram cadastrados
c) qual é a idade da mulher mais jovem
d) qual é a média de idade entre os homens
*/

#include <stdio.h>
#include <stdlib.h>
int main()
{
    int idade;
    char sexo;
    int maiorIdade = 0;
    int quantHomens = 0;
    int idadeMulherJovem = -1;
    int somaIdadeHomens = 0;
    float mediaIdadeHomens = 0;

    char resposta = 'S';
    do
    {
        printf("Sexo [M/F]: ");
        scanf(" %c", &sexo);
        printf("Idade: ");
        scanf("%d", &idade);

        if (idade > maiorIdade)
        {
            maiorIdade = idade;
        }
        if (sexo == 'M' || sexo == 'm')
        {
            somaIdadeHomens += idade;
            quantHomens++;
        }
        if (sexo == 'F' || sexo == 'f')
        {
            if (idadeMulherJovem == -1 || idade < idadeMulherJovem)
            {
                idadeMulherJovem = idade;
            }
        }

        printf("Quer continuar [S/N]: ");
        scanf(" %c", &resposta);

        if (resposta == 'N' || resposta == 'n')
        {
            printf("Analisando todas as informações....\n\n");
            break;
        }
    } while (resposta != 'N' || resposta != 'n');

    mediaIdadeHomens = somaIdadeHomens / quantHomens;

    printf("A maior idade lida foi %d anos\n", maiorIdade);
    printf("A quantidade de homens cadastrados foi %d\n", quantHomens);
    if (idadeMulherJovem != -1) printf("A mulher mais jovem tem %d anos\n", idadeMulherJovem);
    printf("A média de idade entre os homens é de %.2f anos\n\n", mediaIdadeHomens);
    return 0;
}