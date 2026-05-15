#include <stdio.h>
#include <stdlib.h>

int main(){
    int pa, razao;
    
    printf("\n====================================\n");
    printf("\n          10 TERMOS DE UMA PA       \n");
    printf("\n====================================\n");
    
    printf("Primeiro Termo: ");
    scanf("%d", &pa);

    printf("Razão: ");
    scanf("%d", &razao);
    
    printf("\nTermos da PA: ");
    for(int i = 1; i <= 10; i++){
        printf("%d ", pa);
        pa = pa + razao;
    }
    
    printf("\nACABOU\n");
    return 0;
}