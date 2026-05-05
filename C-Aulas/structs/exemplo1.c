#include <stdio.h>

struct produto{
    int codigo;
    char descricao[30];
    float preco;
    int saldo;
};

int main(){
    int tam = 2;
    struct produto ficha[tam];
    
    int i;

    for (i = 0; i < tam; i++){
        printf("digite o código do produto: ");
        scanf("%d",&ficha[i].codigo);
        printf("digite a descrição do produto: ");
        scanf("%s",&ficha[i].descricao);
        printf("Digite o preço do produto: ");
        scanf("%f",&ficha[i].preco);
        printf("Digite o saldo do produto: ");
        scanf("%d",&ficha[i].saldo);
    }
    for(i = 0; i < tam;i++){
        printf("\n-----------PRODUTO------------\n");
        printf("código: %d\n",ficha[i].codigo);
        printf("descrição: %s\n",ficha[i].descricao);
        printf("preço: %.2f\n",ficha[i].preco);
        printf("saldo: %d\n",ficha[i].saldo);
    }

    return 0;
}