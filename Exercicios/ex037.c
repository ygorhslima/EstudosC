/*
37) Uma empresa precisa reajustar o salário dos seus funcionários, dando um
aumento de acordo com alguns fatores. Faça um programa que leia o salário atual,
o gênero do funcionário e há quantos anos esse funcionário trabalha na empresa.
No final, mostre o seu novo salário, baseado na tabela a seguir:
- Mulheres
- menos de 15 anos de empresa: +5%
- de 15 até 20 anos de empresa: +12%
- mais de 20 anos de empresa: +23%
- Homens
- menos de 20 anos de empresa: +3%
- de 20 até 30 anos de empresa: +13%
- mais de 30 anos de empresa: +25%
*/

#include <stdio.h>
#include <stdlib.h>

int main(){
    float salario;
    char sexo;
    int anos_trabalho;
    float aumento;

    printf("Salário atual do funcionário: ");
    scanf("%f", &salario);

    printf("Gênero do funcionário [M/F]: ");
    scanf(" %c", &sexo);

    printf("Anos de trabalho deste funcionário: ");
    scanf("%d", &anos_trabalho);

    if(sexo == 'F'){
        if(anos_trabalho <= 15){
            aumento = salario + (salario * 0.05);
        }
        else if (anos_trabalho > 15 && anos_trabalho <= 20){
            aumento = salario + (salario * 0.12);
        }else if (anos_trabalho > 20){
            aumento = salario + (salario * 0.23);
        }
    }

    if(sexo == 'M'){
        if(anos_trabalho <= 20){
            aumento = salario + (salario * 0.03);
        }
        else if(anos_trabalho > 20 && anos_trabalho <= 30){
            aumento = salario + (salario * 0.13);
        }
        else if(anos_trabalho > 30){
            aumento = salario + (salario * 0.25);
        }
    }

    printf("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
    printf("        Dados do funcionário      \n");
    printf("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
    printf("Salário atual: R$%.2f\n", salario);
    printf("sexo: %c\n", sexo);
    printf("Anos de trabalho: %d anos \n", anos_trabalho);
    printf("O aumento do salário do funcionário foi de R$%.2f\n\n", aumento);

    return 0;
}