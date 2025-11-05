#include <stdio.h>

int main()
{
    float altura[5];
    float menorAltura = 999;

    for(int i=0;i<5;i++){
        printf("Digite a altura: ");
        scanf("%f",&altura[i]);

        if(altura[i] < menorAltura){
            menorAltura = altura[i];
        }
    }

    printf("A menor altura foi de %.2f",menorAltura);
    return 0;
}
