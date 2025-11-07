#include <stdio.h>

int main(){
    
    int idade;
    printf("informe sua idade: ");
    scanf("%d",&idade);
    if(idade < 16){
        printf("não eleitor");
    }else if((idade < 18) || (idade > 65)){
        printf("eleitor facultativo");
    }else{
        printf("eleitor obrigatório");
    }
    
    return 0;
}