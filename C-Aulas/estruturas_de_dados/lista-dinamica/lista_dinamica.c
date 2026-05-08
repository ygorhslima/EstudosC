#include <stdio.h>
#include <stdlib.h>
#include <time.h>

// Correção do typedef para C puro
typedef struct NO {
    int dado;
    struct NO *prox;
} NO;

typedef NO *ptr_no;

ptr_no lista = NULL; // Começamos com a lista vazia
int op;

void menu_mostrar();
void menu_selecionar(int op);
void lista_inserir();
void lista_remover();
void lista_mostrar();

int main() {
    srand(time(NULL));
    op = 1;

    while (op != 0) {
        menu_mostrar();
        scanf("%d", &op);
        menu_selecionar(op);
    }
    return 0;
}

void menu_mostrar() {
    system("clear || cls"); // Limpa no Linux ou Windows
    lista_mostrar();
    printf("\n\nEscolha uma das opcoes: \n");
    printf("1 - Inserir no final da Lista\n");
    printf("2 - Remover um item na lista\n");
    printf("0 - Sair\n\n");
}

void menu_selecionar(int op) {
    switch (op) {
        case 1: lista_inserir(); break;
        case 2: lista_remover(); break;
    }
}

void lista_inserir() {
    ptr_no novo = (ptr_no)malloc(sizeof(NO));
    novo->dado = rand() % 100;
    novo->prox = NULL;

    if (lista == NULL) {
        lista = novo;
    } else {
        ptr_no temp = lista;
        while (temp->prox != NULL) {
            temp = temp->prox;
        }
        temp->prox = novo;
    }
}

void lista_remover() {
    int valor;
    printf("\nEscolha o item para remover: ");
    scanf("%d", &valor);

    if (lista == NULL) return;

    ptr_no atual = lista;
    ptr_no anterior = NULL;

    // Busca o nó com o valor
    while (atual != NULL && atual->dado != valor) {
        anterior = atual;
        atual = atual->prox;
    }

    if (atual != NULL) { // Achou o item
        if (anterior == NULL) { // É o primeiro da lista
            lista = atual->prox;
        } else { // Está no meio ou fim
            anterior->prox = atual->prox;
        }
        free(atual); // Importante: libera a memória!
    }
}

void lista_mostrar() {
    ptr_no temp = lista;
    printf("LISTA: ");
    if (temp == NULL) printf("Vazia");

    while (temp != NULL) {
        printf("[%d] ", temp->dado);
        temp = temp->prox;
    }
}