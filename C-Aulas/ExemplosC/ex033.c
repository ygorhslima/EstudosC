#include <stdio.h>
#include <stdlib.h>
/*
O Índice de Massa Corpórea (IMC) é um valor calculado baseado na altura e no
peso de uma pessoa. De acordo com o valor do IMC, podemos classificar o
indivíduo dentro de certas faixas.
- abaixo de 18.5: Abaixo do peso
- entre 18.5 e 25: Peso ideal
- entre 25 e 30: Sobrepeso
- entre 30 e 40: Obesidade
- acima de 40: Obseidade mórbida
*/

int main(){
    float IMC, peso, altura;

    printf("Digite seu peso: ");
    scanf("%f", &peso);

    printf("Digite sua Altura: ");
    scanf("%f", &altura);

    IMC = peso / (altura*altura);
  c  
    printf("-=-=-=-=-=-=-=-=-=-=-=-=DADOS-=-=-=-=-=-=-=-=-=-=-=-=\n");
    printf("Peso: %.2f\n", peso);
    printf("Altura: %.2f\n", altura);
    printf("IMC: %.2f\n", IMC);
    printf("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
    
    if(IMC < 18.5){
        printf("Abaixo do Peso\n");
    }else if (IMC <= 25){
        printf("Peso Ideal\n");
    }else if (IMC <= 30){
        printf("Sobrepeso\n");
    }else if (IMC <= 40){
        printf("Obesidade\n");
    }else if (IMC > 40){
        printf("Obesidade Mórbida\n");
    }
    return 0;
}