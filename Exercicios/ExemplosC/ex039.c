#include <stdio.h>
#include <stdlib.h>
int main()
{
    for(int i=2; i<51; i = i += 2){
        printf("%d ", i);
    }
    printf("Acabou");
    printf("\n");
    return 0;
}