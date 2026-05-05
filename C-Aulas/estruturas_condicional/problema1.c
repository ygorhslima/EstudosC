#include <stdio.h>
#include <stdlib.h>

int main(){
    // leia um número e informe se é divisível por 5
    int num;
    printf("digite um valor: ");
    scanf("%d",&num);
    if(num % 5 == 0){
        printf("%d é divisível por 5\n",num);
    }else{
        printf("%d não é divisível por 5\n",num);
    }
    return 0;
}