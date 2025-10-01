#include <stdio.h>
#include <math.h>

/**O problema consiste
em obter um número inteiro e, se este for par, imprimir sua raiz quadrada. */
int main()
{
    int num, quadrado;
    float raiz;
    printf("Digite um número inteiro: ");
    scanf("%d",&num);
    if(num % 2 == 0){
        raiz = sqrt(num);
        printf("a raiz quadrada de %d é %.2f", num,raiz);
    }else{  
        quadrado = num * num;
        printf("\nO número é ímpar.");
        printf("\nO número ao quadrado é: %d\n",quadrado);
    }       
    return 0;
}
