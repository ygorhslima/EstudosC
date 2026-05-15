/*
Crie um algoritmo que leia o valor inicial da contagem, o valor final e o
incremento, mostrando em seguida todos os valores no intervalo:
Ex: Digite o primeiro Valor: 3
Digite o último Valor: 10
Digite o incremento: 2
Contagem: 3 5 7 9 Acabou!
*/
#include <stdio.h>
#include <stdlib.h>
int main(){
    int valorInicial;
    int valorFinal;
    int incremento;

    printf("Digite o primeiro Valor: ");
    scanf("%d", &valorInicial);
    
    printf("Digite o último Valor: ");
    scanf("%d", &valorFinal);

    printf("Digite o incremento: ");
    scanf("%d", &incremento);

    printf("Contagem:"); 
    for(int i = valorInicial; i < valorFinal; i = i + incremento){
        printf("%d ", i);
    }
    printf("Acabou!\n");
    return 0;
}