#include <stdio.h>

int main(){
    int xi;
    int *ptr_xi;
    return 0;
}

void imprimir(){
    printf("Valor de xi = %d \n", xi);
    printf("valor de &xi = %p \n", &xi);
    printf("Valor de ptr_xi = %p \n", ptr_xi);
    printf("Valor de *ptr_xi = %p \n\n", *ptr_xi);
}