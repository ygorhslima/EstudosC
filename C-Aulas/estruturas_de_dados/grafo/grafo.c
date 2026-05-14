#include <stdio.h>
#include <stdlib.h>

#define maximo 10

int tamanho = 0;
int grafo[maximo];
int ma[maximo][maximo] = {0}; // Inicializa a matriz com zeros
int op = -1; // Inicializado para entrar no loop

int grafo_tamanho() {
    int t;
    printf("Escolha a quantidade de vértices do grafo (1 a %d): ", maximo);
    scanf("%d", &t);
    return t;
}

void grafo_inserir() {
    int num1, num2;
    printf("\nEscolha o vértice de origem (0 a %d): ", tamanho - 1);
    scanf("%d", &num1);
    printf("Escolha o vértice de destino (0 a %d): ", tamanho - 1);
    scanf("%d", &num2);

    if (num1 >= tamanho || num2 >= tamanho || num1 < 0 || num2 < 0) {
        printf("\nERRO: Os valores precisam estar entre 0 e %d!\n", tamanho - 1);
        printf("Pressione Enter para continuar...");
        getchar(); getchar(); // Pausa para leitura
    } else {
        ma[num1][num2] = 1;
        ma[num2][num1] = 1;
    }
}

void grafo_remover() {
    int num1, num2;
    printf("\nEscolha o vértice de origem para remover (0 a %d): ", tamanho - 1);
    scanf("%d", &num1);
    printf("Escolha o vértice de destino para remover (0 a %d): ", tamanho - 1);
    scanf("%d", &num2);

    if (num1 >= tamanho || num2 >= tamanho || num1 < 0 || num2 < 0) {
        printf("\nERRO: Os valores precisam estar entre 0 e %d!\n", tamanho - 1);
        printf("Pressione Enter para continuar...");
        getchar(); getchar();
    } else {
        ma[num1][num2] = 0;
        ma[num2][num1] = 0;
    }
}

void grafo_desenhar() {
    printf("Lista de vértices: [ ");
    for (int i = 0; i < tamanho; i++) {
        printf("%d ", grafo[i]);
    }
    printf("]\n");
}

void grafo_desenhar_ma() {
    printf("\nMatriz de Adjacência:\n    ");
    for (int i = 0; i < tamanho; i++) printf("%d   ", i);
    printf("\n");

    for (int i = 0; i < tamanho; i++) {
        printf("%d [ ", i);
        for (int j = 0; j < tamanho; j++) {
            printf("%d   ", ma[i][j]);
        }
        printf("]\n");
    }
}

int main() {
    // Configuração inicial do tamanho
    while (tamanho <= 0 || tamanho > maximo) {
        tamanho = grafo_tamanho();
        if (tamanho <= 0 || tamanho > maximo) {
            printf("Valor inválido! Tente novamente.\n");
        } else {
            for (int i = 0; i < tamanho; i++) {
                grafo[i] = i;
            }
        }
    }
    while (op != 0) {
        printf("\n------------------------------\n");
        grafo_desenhar();
        grafo_desenhar_ma();
        
        printf("\nEscolha uma opção: \n");
        printf("[1] - Inserir aresta\n");
        printf("[2] - Remover aresta\n");
        printf("[0] - Sair\n");
        printf("Opção: ");

        scanf("%d", &op);

        switch (op) {
            case 1: grafo_inserir(); break;
            case 2: grafo_remover(); break;
            case 0: printf("Saindo...\n"); break;
            default: 
                printf("Opção inválida!\n"); 
                getchar(); getchar();
                break;
        }
    }
    return 0;
}