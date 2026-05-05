/**
 *
 * 2) Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boas-
vindas para ela:
Ex:
Qual é o seu nome? João da Silva
Olá João da Silva, é um prazer te conhecer!
 */

#include <stdio.h>
#include <stdlib.h>

int main()
{
    char nome[30];
    printf("Qual é o seu nome? ");
    scanf("%s", &nome);

    printf("Olá %s, é um prazer te conhecer!\n", nome);
    return 0;
}