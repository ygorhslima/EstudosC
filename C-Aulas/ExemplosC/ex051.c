/*
51) Faça um aplicativo que leia o preço de 8 produtos. No final, mostre na tela
qual foi o maior e qual foi o menor preço digitados.
*/
#include <stdio.h>
#include <stdlib.h>
int main()
{
    float preco, maior_preco, menor_preco;
    for (int i = 1; i <= 8; i++)
    {
        printf("Digite o preço do °%d produto: ", i);
        scanf("%f", &preco);

        if(i == 1){
            maior_preco = preco;
            menor_preco = preco;
        }

        if (preco > maior_preco)
        {
            maior_preco = preco;
        }
        if (preco < menor_preco)
        {
            menor_preco = preco;
        }
    }
    printf("O maior preço da lista foi %.1f\n", maior_preco);
    printf("O menor preço foi %.1f\n", menor_preco);
    return 0;
}