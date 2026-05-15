#include <stdio.h>
#include <stdlib.h>
int main()
{
    int n;
    printf("Digite o número para ver sua tabuada: ");
    scanf("%d", &n);
    for (int i = 1; i < 11; i++)
    {
        int calc = n * i;
        printf("%d x %d = %d\n", n, i, calc);
    }
    return 0;
}