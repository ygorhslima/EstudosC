#include <stdio.h>

/**
 * Etapa 1: Planejamento e Estrutura do Código - Antes de começar a codificar, planeje a estrutura do seu programa.


*/

/*
Declare as constantes e variáveis: Use #define para definir uma constante para o tamanho do acervo (TAMANHO_ACERVO 20). Na função main, declare um vetor dessa struct (struct Livro acervo[TAMANHO_ACERVO]) e outras variáveis auxiliares.
*/

#define TAMANHO_ACERVO 20

// definfindo uma struct
struct Livro{
    int codigo;
    char titulo[50];
    char autor[30];
    char area[30];
    int ano;
    char editora[30];
};

void cadastrarLivros(struct Livro acervo[], int tamanho){

}

void imprimirLivros(struct Livro acervo[], int tamanho){

}

void pesquisarLivros(struct Livro acervo[], int tamanho, int codigoBusca){

}

void ordenarLivros(struct Livro acervo[], int tamanho){

}



int main()
{
    // array acervo usado para guardar os livros dentro de uma array
    struct Livro acervo[TAMANHO_ACERVO];

    // variável responsável por guardar a escolha do usuário no menu
    int opcao;
    // o código do livro para buscar na função de pesquisarLivros
    int codigoBusca;

    do
    {
        printf("\n------------ GERENCIADOR DE LIVROS ------------\n");
        printf("[1] Cadastrar livros\n");
        printf("[2] Imprimir todos os Livros\n");
        printf("[3] Pesquisar livro por códigon\n");
        printf("[4] Ordenar Livros por ano de publicação\n");
        printf("[5] sair do programa\n");
        // parte importante para o loop funcionar
        printf("qual é a sua opção: ");
        scanf("%d",&opcao);
        
        switch (opcao){
            case 1:
                cadastrarLivros(acervo, TAMANHO_ACERVO);
                break;
            case 2:
                imprimirLivros(acervo, TAMANHO_ACERVO);
                break;
            case 3:
                printf("qual é o código do livro que você quer buscar?: ");
                scanf("%d",&codigoBusca);
                pesquisarLivros(acervo, TAMANHO_ACERVO, codigoBusca);
                break;
            case 4:
                ordenarLivros(acervo, TAMANHO_ACERVO);
                break;
            case 5:
                printf("saindo do programa....\n");
                break;
            default:
                printf("\n----------------------------------\n");
                printf("\n     digite uma opção válida      \n");
                printf("\n----------------------------------\n");
                break;
        }
    }while(opcao != 5);


    return 0;
}