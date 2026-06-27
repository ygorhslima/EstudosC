/*
30) [DESAFIO] Refaça o algoritmo 25, acrescentando o recurso de mostrar que tipo
de triângulo será formado:
- EQUILÁTERO: todos os lados iguais
- ISÓSCELES: dois lados iguais
- ESCALENO: todos os lados diferentes
*/

#include <stdio.h>
#include <stdlib.h>
int main() {
    float r1,r2,r3;

    printf("A: ");
    scanf("%f", &r1);

    printf("B: ");
    scanf("%f", &r2);

    printf("C: ");
    scanf("%f", &r3);

    if(r1 < r2 + r3 && r2 < r1 + r3 && r3 < r1 + r2){
        printf("os segmentos PODEM formar um triângulo\n");
        if (r1 == r2 && r2 == r3) {
            printf("EQUILATERO");
        }else if (r1 != r2 && r2 != r3 && r3 != r1) {
            printf("ESCALENO");
        }else if (r1 == r2 || r2 == r3 || r3 == r1) {
            printf("ISÓSCELES");
        }
    }else{
        printf("os segmentos NÃO PODEM formar um triângulo\n");
    }
    return 0;
}