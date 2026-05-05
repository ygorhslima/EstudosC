#include <stdio.h>
#include <stdlib.h>

int main(){
    int idade;
    float valor_mensalidade;
    char nome[30];    
    
    printf("digite o seu nome: ");
    fgets(nome, sizeof(nome), stdin);

    printf("digite a sua idade: ");
    scanf("%d",&idade);
    
    if(idade <= 18){
        valor_mensalidade = 50;
        printf("a mensalidade de %s fica %.2f\n",nome,valor_mensalidade);
    }
    else if(idade >= 19 && idade <= 29){
        valor_mensalidade = 70;
        printf("a mensalidade de %s fica %.2f\n",nome,valor_mensalidade);
    }else if(idade >= 30 && idade <= 45){
        valor_mensalidade = 90;
        printf("a mensalidade de %s fica %.2f\n",nome,valor_mensalidade);
    }else if(idade >= 46 && idade <= 65){
        valor_mensalidade = 130;
        printf("a mensalidade de %s fica %.2f\n",nome,valor_mensalidade);
    }else{
        valor_mensalidade = 170;
        printf("a mensalidade de %s fica %.2f\n",nome,valor_mensalidade);
    }
    return 0;
}