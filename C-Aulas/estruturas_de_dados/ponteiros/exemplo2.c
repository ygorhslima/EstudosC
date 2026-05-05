#include <stdio.h>
#include <stdlib.h>
int main(){
    int *ptr;
    printf("Endereço: %p\n\n", ptr);
    ptr = (int *) malloc(sizeof (int));
    printf("Endereço: %p \nValor: %d\n\n", ptr, *ptr);
    return 0;
}