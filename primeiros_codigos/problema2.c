#include <stdio.h>

int main(){
    float n1,n2,n3,n4;
    printf("informe a 1°a nota: ");
    scanf("%f",&n1);
    printf("informe a 2°a nota: ");
    scanf("%f",&n2);
    printf("informe a 3°a nota: ");
    scanf("%f",&n3);
    printf("informe a 4°a nota: ");
    scanf("%f",&n4);
    float media = (n1+n2+n3+n4) / 4;
    printf("a média foi %.2f\n",media);
    return 0;
}