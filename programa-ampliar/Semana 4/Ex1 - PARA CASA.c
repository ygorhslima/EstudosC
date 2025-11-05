/*
    Escreva um programa em C que receba 10 idades em um vetor.
    O programa deverá informar qual a idade mais velha.
*/

#include <stdio.h>

int main(){
    int idades[10];

    for(int i = 0; i < 10; i++){
        printf("Informe a idade %d: ",i+1);
        scanf("%d",&idades[i]);
    }

    int maiorIdade = idades[0];
    for(int i = 0; i < 10; i++){
        if(idades[i] > maiorIdade){
            maiorIdade = idades[i];
        }
    }

    printf("A maior idade é %d",maiorIdade);
    return 0;
}
