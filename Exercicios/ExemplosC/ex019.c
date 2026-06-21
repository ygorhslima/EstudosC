/*
19) Crie um algoritmo que leia o nome e as duas notas de um aluno, calcule a sua
média e mostre na tela. No final, analise a média e mostre se o aluno teve ou
não um bom aproveitamento (se ficou acima da média 7.0).
*/

#include <stdio.h>
#include <stdlib.h>
int main()
{
    char nome[100];
    float nota1;
    float nota2;
    float media;

    printf("Digite o nome do aluno: ");
    scanf("%s", &nome);

    printf("Digite a primeira nota: ");
    scanf("%f", &nota1);

    printf("Digite a segunda nota: ");
    scanf("%f", &nota2);

    media = (nota1 + nota2) / 2;
    printf("A média foi %.2f\n", media);

    if(media >= 7.0){
        printf("Aluno Aprovado\n");
    }else{
        printf("Aluno Reprovado\n");
    }

    return 0;
}