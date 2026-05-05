#include <stdio.h>
#include <stdlib.h>

int *p;
int x;

int main(){
    x = 10;
    p = &x;
    x = 20;
    *p = 30;
    printf("Conteúdo de X: %d\n", x);
    printf("Endereço de X: %p\n", &x);
    printf("Conteúdo de P: %p\n", p);
    printf("Conteúdo do ponteiro p: %p\n\n", *p);
    return 0;
}