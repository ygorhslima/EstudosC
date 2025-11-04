#include <stdio.h>
/**
 * 
 * O  problema  consiste  em  ler  um  conjunto  de  números  inteiros  e  contar  a  
quantidade  de  números  pares  e  ímpares. A  leitura  deve  ser  realizada  até  
que seja lido o valor zero.
A  entrada  de  dados  consiste  na  leitura  de  números  inteiros  repetidas  ve-
zes, até que o valor zero seja digitado. O processamento é contar a quantidade 
de números pares e ímpares. E a saída é informar quantos dos números lidos 
na entrada são pares e quantos são ímpares. No Quadro 4, é apresentado um 
programa para este problema, utilizando a estrutura while
 */
int main(){
    int pares, impares, num;
    pares = 0;
    impares = 0;
    printf("informe o número: ");
    scanf("%d",&num);
    while(num != 0){
        if(num % 2 == 0){
            pares++;
        }else{
            impares++;
        }
        printf("informe o número: ");
        scanf("%d",&num);
    } 
    printf("A quantidade de valores pares é: %d\n",pares);
    printf("A quantidade de valores ímpar é: %d\n",impares);
    return 0;
}