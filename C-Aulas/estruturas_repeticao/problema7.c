#include <stdio.h>

/**
 * escreva um programa que:
 * - receba a idade e a altura de várias pessoas
 * - calcular e apresentar a média de altura e a idade das pessoas
 * - Condição de parada: quando o usuário digitar o valor zero para a idade
 * 
 */

int main()
{
    int idade;
    float altura;

    // variáveis de incremento
    int npessoas = 0;
    float soma_altura = 0;
    float soma_idade = 0;


    printf("digite sua idade: ");
    scanf("%d",&idade);

    while(idade != 0){
        printf("digite sua altura: ");
        scanf("%f",&altura);
        npessoas++;
        
        soma_idade = soma_idade + idade;
        soma_altura = soma_altura + altura;
        
        printf("digite sua idade: ");
        scanf("%d",&idade);
    }

    float media_altura = soma_altura / npessoas;
    float media_idade = soma_idade / npessoas;

    printf("a média de altura é:%f",media_altura);
    printf("a média de idade é:%f",media_idade);
    
    return 0;
}