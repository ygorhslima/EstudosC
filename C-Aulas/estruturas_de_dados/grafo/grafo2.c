#include <stdio.h>
#include <stdlib.h>
#define MAX_VERTICES 10

typedef struct
{
    int matriz[MAX_VERTICES][MAX_VERTICES];
    int num_vertices;
} GrafoMatriz;

void inicializarGrafo(GrafoMatriz *G, int v)
{
    G->num_vertices = v;
    for (int i = 0; i < v; i++)
    {
        for (int j = 0; j < v; j++)
        {
            G->matriz[i][j];
        }
    }
}

void adicionarArestas(GrafoMatriz *G, int origem, int destino)
{
    G->matriz[origem][destino] = 1;
    G->matriz[destino][origem] = 1;
}

int main()
{
    GrafoMatriz grafo;
    inicializarGrafo(grafo, 4);

    adicionarArestas(&grafo, 0, 1);
    adicionarArestas(&grafo, 0, 2);
    adicionarArestas(&grafo, 1, 3);
    printf("%d\n", grafo.matriz[0][0]);
    return 0;
}