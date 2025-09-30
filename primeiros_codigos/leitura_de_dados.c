#include <stdio.h>

int main(){
    /*definindo variáveis*/
    char nome[30];
    int idade,ano;
    int ano_atual = 2025; 
    float altura;

    /*entrada*/
    printf("digite seu nome: ");
    scanf("%s",&nome);
    printf("digite sua idade: ");
    scanf("%d",&idade);
    printf("altura(m): ");
    scanf("%f",&altura);
    
    /*processamento*/
    ano = ano_atual - idade;
    
    /*saída*/
    printf("------------------------------\n");
    printf("nome: %s\n",nome);
    printf("idade: %d\n",idade);
    printf("altura: %f\n",altura);
    printf("ano de nascimento: %d\n",ano);
    printf("------------------------------\n");
    return 0;
}