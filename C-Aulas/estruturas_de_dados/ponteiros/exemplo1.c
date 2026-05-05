#include <stdio.h>

int xi;
int *ptr_xi;

void imprimir(){
    printf("Valor de xi = %d \n", xi);
    printf("valor de &xi = %p \n", &xi);
    printf("Valor de ptr_xi = %p \n", ptr_xi);
    printf("Valor de *ptr_xi = %p \n\n", *ptr_xi);
}

int main(){
    xi = 10;
    ptr_xi = &xi;
    imprimir();
    return 0;
}
