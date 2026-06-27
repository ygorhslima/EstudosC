/*
65) Desenvolva um programa usando a estrutura “para” que mostre na tela a
seguinte contagem:
100 90 80 70 60 50 40 30 20 10 0 Acabou!
*/
#include <stdio.h>
#include <stdlib.h>
int main()
{
    for (int i = 100; i >= 0; i = i - 10)
    {
        printf(" %d", i);
    }
    printf(" Acabou!\n");
    return 0;
}