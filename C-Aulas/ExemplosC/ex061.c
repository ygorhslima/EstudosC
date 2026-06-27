/*
61) Crie um programa que mostre na tela a seguinte contagem, usando a estrutura
“faça enquanto”
0 3 6 9 12 15 18 21 24 27 30 Acabou!
*/

#include <stdio.h>
#include <stdlib.h>

int main(){
    int cont = 0;
    while(cont <= 30){
        if(cont % 2 == 0){
            printf("%d ", cont);
        }
        cont++;
    }
    return 0;
}