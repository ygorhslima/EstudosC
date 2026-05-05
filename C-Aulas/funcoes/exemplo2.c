#include <stdio.h>

int soma(float n1, float n2){
    float total;
    total = n1 + n2;
    return total;
}

int main(){
    float n1,n2,res;

    printf("digite um número: ");
    scanf("%f",&n1);
    printf("digite outro número: ");
    scanf("%f",&n2);

    res = soma(n1,n2);
    printf("A soma é igual a %.2f",res);

    return 0;
}