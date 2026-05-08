#include <stdio.h>
#include <stdlib.h>
#define tamanho 3

struct tipo_pilha {
    int dados[tamanho];
    int ini;
    int topo;
};

struct tipo_pilha pilha;

void empilhar(int elemento) {
    if (pilha.topo == tamanho) {
        printf("Fila cheia.\n");
        system("pause");
    }else {
        pilha.dados[pilha.topo] = elemento;
        pilha.topo++;
    }
}

int desempilhar() {
    int elemento;
    if (pilha.topo == pilha.ini) {
        printf("Pilha vazia \n");
        system("pause");
    }else {
        pilha.topo--;
        elemento = pilha.dados[pilha.topo];
        return elemento;
    }
}

int main() {
    // 1. Inicialização (Obrigatória!)
    pilha.ini = 0;
    pilha.topo = 0;

    // 2. Empilhando elementos (Push)
    printf("Empilhando 10, 20 e 30...\n");
    empilhar(10);
    empilhar(20);
    empilhar(30);

    // Tentando empilhar em uma pilha cheia (tamanho é 3)
    empilhar(40);

    // 3. Desempilhando elementos (Pop)
    printf("\nDesempilhando elementos:\n");
    printf("Retirei: %d\n", desempilhar()); // Deve sair 30 (LIFO)
    printf("Retirei: %d\n", desempilhar()); // Deve sair 20

    return 0;
}