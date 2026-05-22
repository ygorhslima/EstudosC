/*
81) Crie um programa que leia a idade de 8 pessoas e guarde-as em um vetor. No
final, mostre:
a) Qual é a média de idade das pessoas cadastradas
b) Em quais posições temos pessoas com mais de 25 anos
c) Qual foi a maior idade digitada (podem haver repetições)
d) Em que posições digitamos a maior idade
*/

#include <stdio.h>
#include <stdlib.h>
#define MAX 8

int main()
{
    int vetor_idades[MAX];
    float media_idade;
    int i, idade;

    int cont = 0;
    int somaIdade = 0;
    int maiorIdade = 0;

    for (i = 0; i < MAX; i++)
    {
        if (i == 1)
        {
            maiorIdade = idade;
        }

        printf("Idade %d: ", i);
        scanf("%d", &idade);

        if (idade > maiorIdade)
        {
            maiorIdade = idade;
        }

        vetor_idades[i] = idade;
        somaIdade += idade;
        cont++;
    }

    // a) Qual é a média de idade das pessoas cadastradas
    media_idade = (float)somaIdade / cont;
    printf("A média de idade das pessoas cadastradas foi de %f\n", media_idade);

    // b) Em quais posições temos pessoas com mais de 25 anos
    printf("Idades acima de 25 anos:\n");
    for (i = 0; i < MAX; i++)
    {
        if (vetor_idades[i] > 25)
        {
            printf("%d na posição %d\n", vetor_idades[i], i);
        }
    }
    // c) Qual foi a maior idade digitada (podem haver repetições)
    printf("A maior idade digitada foi de %d\n", maiorIdade);

    // d) Em que posições digitamos a maior idade
    printf("posição da maior idade\n");
    for (i = 0; i < MAX; i++)
    {
        if (vetor_idades[i] == maiorIdade)
        {
            printf("%d na posição %d\n", vetor_idades[i], i);
        }
    }

    return 0;
}