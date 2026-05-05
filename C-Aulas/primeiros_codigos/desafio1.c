#include <stdio.h>

int main(){
    int n1,n2,n3,n4;
    printf("digite o primeiro valor: ");
    scanf("%d",&n1);
    printf("digite o segundo valor: ");
    scanf("%d",&n2);
    printf("digite o terceiro valor: ");
    scanf("%d",&n3);
    printf("digite o quarto valor: ");
    scanf("%d",&n4);

    float media = (n1+n2+n3+n4) / 4;
    printf("a média dos valores foi de %.2f",media);
    return 0;
}