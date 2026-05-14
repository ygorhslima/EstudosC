#include <stdio.h>
#include <stdlib.h>
#include <time.h> // Para gerar números aleatórios diferentes a cada execução

typedef struct NO {
    int dado;
    struct NO *prox;
} NO;

typedef struct PILHA {
    NO *topo;
} PILHA;

// Função para inicializar a pilha
void inicializa(PILHA *p) {
    p->topo = NULL;
}

void empilha(PILHA *p) {
    NO* ptr = (NO *) malloc(sizeof(NO));
    if(ptr == NULL) return; // Verifica se a alocação falhou

    ptr->dado = rand() % 100;
    ptr->prox = p->topo;
    p->topo = ptr;
    printf("Empilhado: %d\n", ptr->dado);
}

int desempilha(PILHA *p) {
    NO* ptr = p->topo;
    int dado;
    
    if(ptr != NULL) {
        p->topo = ptr->prox;
        dado = ptr->dado;
        free(ptr);
        return dado;
    } else {
        printf("Pilha vazia!\n");
        return -1; // Valor de erro
    }
}

int main() {
    srand(time(NULL)); // Semente para o rand()

    // 1. Criar e alocar a estrutura da pilha
    PILHA *p = (PILHA *) malloc(sizeof(PILHA));
    inicializa(p);

    // 2. Usar a pilha
    empilha(p);
    empilha(p);
    empilha(p);

    printf("\nRemovendo elementos:\n");
    printf("Desempilhado: %d\n", desempilha(p));
    printf("Desempilhado: %d\n", desempilha(p));

    return 0;
}