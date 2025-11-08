#include <stdio.h>

int main(){
    int vetorA[10];
    int i;

    for(i=0;i < 10;i++){
        printf("Digite o %d elemento do vetor: ", i);
        scanf("%d",&vetorA[i]);
    }
    printf("Vetor preenchido\n");
    printf("\n------------------------------------\n");
    for(i=0;i < 10;i++){
        printf("índice %d = [%d] \n",i,vetorA[i]);
    }
    printf("\n------------------------------------\n");
    return 0;
}