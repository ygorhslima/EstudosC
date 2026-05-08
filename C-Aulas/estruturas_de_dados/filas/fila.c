#include <stdio.h>
#include <stdlib.h>

#define tamanho 3

struct tipo_fila {
    int dados[tamanho];
    int ini;
    int fim;
};

struct tipo_fila fila;

void enfileira(int elemento) {
    if (fila.fim == tamanho) {
        printf("Fila cheia.\n");
        system("pause");
    }else {
        fila.dados[fila.fim] = elemento;
        fila.fim++;
    }
}

int desenfileira() {
    int elemento;
    if (fila.fim == fila.ini) {
        printf("Fila vazia.\n");
        system("pause");
    }else {
        elemento = fila.dados[fila.ini];
        for (int i=0; i < tamanho; i++) {
            fila.dados[i] = fila.dados[i+1];
        }
        fila.dados[fila.fim] = 0;
        fila.fim--;
        return elemento;
    }
}

int main() {
    // 1. Inicialização (Crucial para não pegar lixo de memória)
    fila.ini = 0;
    fila.fim = 0;

    // 2. Enfileirando elementos (Enqueue)
    printf("Enfileirando 10, 20 e 30...\n");
    enfileira(10);
    enfileira(20);
    enfileira(30);

    // Tentando colocar um 4º elemento (o tamanho é 3)
    enfileira(40);

    // 3. Desenfileirando elementos (Dequeue)
    printf("\nDesenfileirando elementos:\n");

    // O 10 foi o primeiro a entrar, então será o primeiro a sair
    printf("Saiu: %d\n", desenfileira());

    // Agora o 20 passou para a primeira posição (devido ao seu laço 'for')
    printf("Saiu: %d\n", desenfileira());

    return 0;
}