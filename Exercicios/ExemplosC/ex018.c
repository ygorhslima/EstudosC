/*
18) Faça um programa que leia o ano de nascimento de uma pessoa, calcule a idade
dela e depois mostre se ela pode ou não votar.
*/
#include <stdio.h>
#include <stdlib.h>
int main(){
    int ano_nascimento;
    int ano_atual = 2026;
    int idade;

    printf("digite seu ano de nascimento: ");
    scanf("%d", &ano_nascimento);
    
    idade = ano_atual - ano_nascimento;
    printf("você tem %d anos\n", idade);
    
    if(idade < 18){
        printf("E não pode votar\n");
    }else{
        printf("E pode votar\n");
    }
    return 0;
}