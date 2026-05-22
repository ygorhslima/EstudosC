/*
82) Faça um algoritmo que leia a nota de 10 alunos de uma turma e guarde-as em
um vetor. No final, mostre:
a) Qual é a média da turma
b) Quantos alunos estão acima da média da turma
c) Qual foi a maior nota digitada
d) Em que posições a maior nota aparece
*/
#include <stdio.h>
#include <stdlib.h>
#define MAX 10
int main()
{
    float vetor[MAX];
    int i;
    float nota, somaNota = 0, mediaNota = 0, maiorNota = 0;
    int cont = 0;

    for (i = 0; i < MAX; i++)
    {
        printf("%d°a Nota: ", i + 1);
        scanf("%f", &nota);

        if (i == 0)
        {
            maiorNota = nota;
        }
        if (nota > maiorNota)
        {
            maiorNota = nota;
        }

        vetor[i] = nota;
        somaNota += nota;
        cont++;
    }

    // A)  Qual é a média da turma
    mediaNota = somaNota / cont;
    printf("A média de nota da turma é de %.2f\n", mediaNota);
    printf("A maior nota foi %.2f\n", maiorNota);

    // B)  Quantos alunos estão acima da média da turma
    for (i = 0; i < MAX; i++)
    {
        if (vetor[i] > mediaNota)
        {
            printf("Nota acima da média: %.2f na posição %d\n", vetor[i], i);
        }
    }
    for (i = 0; i < MAX; i++)
    {
        if (vetor[i] == maiorNota)
        {
            printf("A maior nota encontrada foi %.2f na posição %d\n", vetor[i], i);
        }
    }
    return 0;
}