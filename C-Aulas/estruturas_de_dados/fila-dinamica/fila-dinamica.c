#include <stdio.h>
#include <stdlib.h>

typedef struct NO
{
    int dado;
    struct NO *prox;
} NO;

typedef struct FILA
{
    NO *inicio;
    NO *fim;
} FILA;

FILA *f;

void enfileira()
{
    NO *ptr = (NO *)malloc(sizeof(NO));
    ptr->dado = rand() % 100;
    ptr->prox = NULL;

    if (f->inicio == NULL)
    {
        f->inicio = ptr;
    }
    else
    {
        f->fim->prox = ptr;
    }
    f->fim = ptr;
}

int desenfileira()
{
    NO *ptr = f->inicio;
    int dado;
    if (ptr != NULL)
    {
        f->inicio = ptr->prox;
        // desligando o ponteiro que aponta para o dado antigo
        ptr->prox = NULL;
        dado = ptr->dado;
        // liberando espaço na memória
        free(ptr);
        return dado;
    }
}

int main()
{
    return 0;
}