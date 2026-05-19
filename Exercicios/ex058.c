/*
58) Faça um algoritmo que leia a idade de vários alunos de uma turma. O programa
vai parar quando for digitada a idade 999. No final, mostre quantos alunos
existem na turma e qual é a média de idade do grupo.
*/
#include <stdio.h>
#include <stdlib.h>
int main(){
    int idade;
    int quantAlunos = 0;
    int somaIdades;
    float mediaIdades = 0;

    while(idade != 999){
        printf("digite uma idade [999 para encerrar a contagem]: ");
        scanf("%d", &idade);

        if(idade == 999){
            printf("analisando as informações...");
            break;
        }
        somaIdades += idade;
        quantAlunos++;
    }
    mediaIdades = somaIdades / quantAlunos;
    printf("quantidade de alunos na turma é de: %d\n", quantAlunos);
    printf("A média de idade da turma é de %f\n\n", mediaIdades);
    
    return 0;
}