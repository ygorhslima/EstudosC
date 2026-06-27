/*

22) Escreva um programa que leia o ano de nascimento de um rapaz e mostre a sua
situação em relação ao alistamento militar.
- Se estiver antes dos 18 anos, mostre em quantos anos faltam para o
alistamento.
- Se já tiver depois dos 18 anos, mostre quantos anos já se passaram do
alistamento.

*/

#include <stdio.h>
#include <stdlib.h>
int main()
{
    int ano_nascimento, idade;
    int ano_atual = 2026;

    printf("digite o seu ano de nascimento: ");
    scanf("%d", &ano_nascimento);

    idade = ano_atual - ano_nascimento;
    printf("quem nasceu em %d tem %d anos em %d\n", ano_nascimento, idade, ano_atual);

    if (idade < 18)
    {
        int falta = 18 - idade;
        printf("ainda faltam %d anos para o seu alistamento\n", falta);
        printf("seu alistamento será em %d\n", ano_atual + falta);
    }
    else if (idade > 18)
    {
        int passou = idade - 18;
        printf("já se passaram %d anos do seu alistamento\n", passou);
    }

    return 0;
}