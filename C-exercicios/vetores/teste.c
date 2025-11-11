#include <stdio.h>
#define MAX 5

int pertence(int x, int L[], int n);
int main(void){
    int A[MAX] = {9, 1, 2, 7};
       int i, numero;
       numero = 1;
    if(i = pertence(numero, A, MAX))
        printf("Sim!!! O valor pertence a posição [%d]", i);
    else
        printf("Não!!!");
}
int pertence(int x, int L[], int n) {
    int i, j;
    j = 1;
       for(i=0; i<n; i++)       
           if( x == L[i] )
          return i;
       return 0;
}