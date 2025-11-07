#include <stdio.h>
/*
    Construa um programa que receba um número inteiro maior que um e verifique se ele é primo
*/
int main()
{
    int num,i,qtdade;

    printf("Informe o número: \n");
    scanf("%d",&num);
    
    qtdade = 0;
    for(i=1; i <= num; i++){
        if(num % i == 0){
            qtdade++;
        }
    }
    
    if(qtdade == 2){
        printf("o número é primo\n");
    }else{
        printf("não é primo");
    }
    
    return 0;
}