/*
7) Crie um algoritmo que leia um número real e mostre na tela o seu dobro e a
sua terça parte.
Ex:
Digite um número: 3.5
O dobro de 3.5 é 7.0
A terça parte de 3.5 é 1.16666
*/
#include <stdio.h>
#include <stdlib.h>
int main(){
    float n, dobro,terca;
    
    printf("Digite um número: ");
    scanf("%f", &n);

    dobro = n * 2;
    terca = n / 3;

    printf("O dobro de %.2f é %.2f\n", n, dobro);
    printf("A terça parte de %.2f é %.2f\n", n, terca);

    return 0;
}