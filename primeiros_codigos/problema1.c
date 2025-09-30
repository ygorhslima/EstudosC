#include <stdio.h>

int main(){
    int num;
    printf("Digite um número qualquer: ");
    scanf("%d",&num);    

    int antecessor = num - 1;
    int sucessor = num + 1;
    
    printf("o antecessor é %d\n",antecessor);
    printf("o sucessor é %d\n",sucessor);
    return 0;
}