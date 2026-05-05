#include <stdio.h>
int main()
{
    int num,i,fat;
    printf("informe um número: ");
    scanf("%d",&num);
    fat = 1;
    for(i=1;i<=num;i++){
        fat = fat * i;
    }
    printf("O fatorial é: %d\n",fat);
    return 0;
}