#include <stdio.h>

/*
 *   - Faça um programa que leia números inteiros X
 *   - condição de parada: informar o valor 0; X
 *   - Apresente a média dos valores
 *   - o maior e o menor valor X
 *   - a quantidade de números pares e ímpares 
 */

int main(){
    // ler os números inteiros
    int valor, soma_valores=0, maior_valor=0, menor_valor=0, qtd_pares=0, qtd_impares=0, qtd_valores=0;
    float media_valores=0;

    printf("digite um valor: ");
    scanf("%d",&valor);

    while(valor != 0){
        soma_valores += valor;
        qtd_valores++;

        //verificando se um valor é o valor valor
        if(qtd_valores == 1){
            maior_valor = valor;
            menor_valor = valor;
        }else{
            if(valor > maior_valor){
                maior_valor = valor;
            }
            if(valor < menor_valor){
                menor_valor = valor;
            }
        }

        // verificando valores pares e ímpares
        if(valor % 2 == 0){
            qtd_pares++;
        }else{
            qtd_impares++;
        }
        
        printf("digite um valor: ");
        scanf("%d",&valor);
    }

    if(qtd_valores > 0){
        media_valores = (float) soma_valores / qtd_valores;
    }

    printf("A média dos valores foi de:....%.2f\n",media_valores);
    printf("o maior valor digitado foi:....%d\n", maior_valor);
    printf("o menor valor digitado foi:....%d\n", menor_valor);
    printf("quantidade de valores pares:...%d\n", qtd_pares);
    printf("quantidade de valores ímpares:.%d\n", qtd_impares);

    
    return 0;
}