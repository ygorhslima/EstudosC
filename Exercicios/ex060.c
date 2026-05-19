/*
60) Desenvolva um algoritmo que leia o nome, a idade e o sexo de várias pessoas.
O programa vai perguntar se o usuário quer ou não continuar. No final, mostre:
a) O nome da pessoa mais velha
b) O nome da mulher mais jovem
c) A média de idade do grupo
d) Quantos homens tem mais de 30 anos
e) Quantas mulheres tem menos de 18 anos
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int main()
{
    char nome[100];
    int idade;
    char sexo;
    char resposta;

    char nomePessoaVelha[100];
    char nomeMulherMaisJovem[100];

    int maiorIdade = -1;
    int menorIdadeMulher = 999;
    int flagMulher = 0;
    
    int quantHomensMais30 = 0;
    int quantMulheresMenos18 = 0;
    
    int somaIdades = 0;
    int cont = 0;
    float mediaIdadeGrupo = 0;
    do
    {
        printf("Nome: ");
        scanf("%s", &nome);
        printf("Idade: ");
        scanf("%d", &idade);
        printf("Sexo: ");
        scanf(" %c", &sexo);

        somaIdades += idade;
        cont++;

        if (cont == 1 || idade > maiorIdade) {
            maiorIdade = idade;
            strcpy(nomePessoaVelha, nome);
        }

        if(sexo == 'M'){
            if(idade > 30){
                quantHomensMais30++;
            }
        }
        if(sexo == 'F'){
            if(idade < 18){
                quantMulheresMenos18++;
            }
            if(flagMulher == 0 || idade < menorIdadeMulher){
                menorIdadeMulher = idade;
                strcpy(nomeMulherMaisJovem, nome);
                flagMulher = 1;
            }
        }
        
        printf("Quer continuar [S/N]: ");
        scanf(" %c", &resposta);
        if (resposta == 'N')
        {
            printf("analisando os dados obtidos...");
            break;
        }
    } while (resposta != 'N');

    if(cont > 0){
        mediaIdadeGrupo = (float) somaIdades / cont;
    }else{
        mediaIdadeGrupo = 0;
    }
    
    printf("\n========================== RESULTADOS OBTIDOS ==========================\n");
    printf("A pessoa mais velha é: %s (%d anos)\n", nomePessoaVelha, maiorIdade);
    if (flagMulher) {
        printf("b) A mulher mais jovem é: %s (%d anos)\n", nomeMulherMaisJovem, menorIdadeMulher);
    } else {
        printf("b) Nenhuma mulher foi cadastrada no grupo.\n");
    }
    printf("A média de idade do grupo é de %.2f anos\n", mediaIdadeGrupo);
    printf("Quantidade de homens que tem mais de 30 anos: %d\n", quantHomensMais30);
    printf("Quantidade de mulheres que tem menos de 18 anos: %d\n\n", quantMulheresMenos18);
    return 0;
}