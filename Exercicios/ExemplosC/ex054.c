/*
54) Desenvolva um aplicativo que leia o peso e a altura de 7 pessoas, mostrando
no final:
a) Qual foi a média de altura do grupo
b) Quantas pessoas pesam mais de 90Kg
c) Quantas pessoas que pesam menos de 50Kg tem menos de 1.60m
d) Quantas pessoas que medem mais de 1.90m pesam mais de 100Kg.
*/

#include <stdio.h>
#include <stdlib.h>
int main()
{
    float mediaAlturaGrupo;
    int somaAltura;
    int quantPessoaMais90kg;
    int quantPessoaMenos50kg;
    int quantPessoaMaisDe190mMais100Kg;
    int cont;

    float peso;
    float altura;

    for(int i=1; i<=7; i++){
        printf("============== %d° pessoa==============\n",i);
        printf("Peso: ");
        scanf("%f", &peso);
        printf("Altura: ");
        scanf("%f", &altura);
        somaAltura += altura;

        //b) Quantas pessoas pesam mais de 90Kg
        if(peso > 90){
            quantPessoaMais90kg++;
        }

        //c) Quantas pessoas que pesam menos de 50Kg tem menos de 1.60m
        if(peso < 50 && altura < 1.60){
            quantPessoaMenos50kg++;
        }

        //d) Quantas pessoas que medem mais de 1.90m pesam mais de 100Kg.
        if(altura > 1.90 && peso > 100){
            quantPessoaMaisDe190mMais100Kg++;
        }
        cont++;
    }
    
    //a) Qual foi a média de altura do grupo
    mediaAlturaGrupo = somaAltura / cont;
    printf("A média de altura do grupo foi de: %f\n", mediaAlturaGrupo);
    printf("Quantidade de Pessoas que pesam mais de 90kg: %d\n", quantPessoaMais90kg);
    printf("Quantidade de pessoas que pesam menos de 50kg e tem menos de 1.60m: %d\n", quantPessoaMenos50kg);
    printf("Quantidade de pessoas que medem mais de 1.90m e pesam mais de 100kg: %d\n\n", quantPessoaMaisDe190mMais100Kg);

    return 0;
}