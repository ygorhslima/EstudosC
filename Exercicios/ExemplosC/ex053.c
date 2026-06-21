/*
53) Faça um programa que leia a idade e o sexo de 5 pessoas, mostrando no final:
a) Quantos homens foram cadastrados
b) Quantas mulheres foram cadastradas
c) A média de idade do grupo
d) A média de idade dos homens
e) Quantas mulheres tem mais de 20 anos
*/
#include <stdio.h>
#include <stdlib.h>

int main()
{
    // variáveis principais
    int idade;
    char sexo;
    int cont;

    // soma das idades
    int somaIdade;
    int somaIdadeHomens;
    
    // quantificadores
    int quantHomensCadastrados;
    int quantMulheresCadastrados;
    int quantMulheresMais20;
    
    // média de grupos
    float mediaIdadeGrupo;
    float mediaIdadeGrupoHomens;
 

    // leia a idade e o sexo de 5 pessoas
    for (int i = 1; i <= 5; i++)
    {
        printf("===================== %d° pessoa =====================\n", i);
        printf("Idade: ");
        scanf("%d", &idade);
        printf("Sexo [M/F]: ");
        scanf(" %c", &sexo);
        printf("======================================================\n\n", i);

        // variável que vai somar todas as idades para o resultado da média funcionar
        somaIdade += idade;

        // a) Quantos homens foram cadastrados
        if (sexo == 'M' || sexo == 'm')
        {
            somaIdadeHomens += idade;
            quantHomensCadastrados++;
        }

        // b) Quantas mulheres foram cadastradas
        if (sexo == 'F' || sexo == 'f')
        {
            // e) Quantas mulheres tem mais de 20 anos
            if(idade > 20){
                quantMulheresMais20++;
            }
            quantMulheresCadastrados++;
        }
        cont++;
    }
    
    // c) A média de idade do grupo
    mediaIdadeGrupo = somaIdade / cont;

    // d) A média de idade dos homens
    mediaIdadeGrupoHomens = somaIdadeHomens / quantHomensCadastrados;

    printf("======================= RESULTADO =======================\n");
    printf("Quantidade de homens cadastrados...........: %d\n", quantHomensCadastrados);
    printf("Quantidade de mulheres cadastradas.........: %d\n", quantMulheresCadastrados);
    printf("A média de idade do grupo geral é de.......: %f\n", mediaIdadeGrupo);
    printf("A média de idade do grupo de homens é de...: %f\n", mediaIdadeGrupoHomens);
    printf("A quantidade de mulheres acima de 20 anos é: %d\n\n", quantMulheresMais20);
    printf("=========================================================\n");
    return 0;
}