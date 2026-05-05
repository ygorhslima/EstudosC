#include <stdio.h>   // para printf, scanf, fgets
#include <string.h>  // para strcspn e funções de string
#define TAMANHO_ACERVO 3
// definfindo uma struct
struct Livro{
    int codigo;
    char titulo[50];
    char autor[30];
    char area[30];
    int ano;
    char editora[30];
};

void cadastrarLivros(struct Livro acervo[], int tamanho);
void imprimirLivros(struct Livro acervo[], int tamanho);
void pesquisarLivros(struct Livro acervo[], int tamanho, int codigoBusca);
void ordenarLivros(struct Livro acervo[], int tamanho);

int main()
{
    // array acervo usado para guardar os livros dentro de uma array
    struct Livro acervo[TAMANHO_ACERVO];
    // variável responsável por guardar a escolha do usuário no menu
    int opcao;
    // o código do livro para buscar na função de pesquisarLivros
    int codigoBusca;
    // o ano do livro que será usado para filtrar livros do mesmo ano
    int anoLivro;    
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
            case 1: /*cadastrar livro*/
                cadastrarLivros(acervo, TAMANHO_ACERVO);
                break;
            case 2: /*imprimir Livro*/
                imprimirLivros(acervo, TAMANHO_ACERVO);
                break;
            case 3: /* pesquisar Livro */
                printf("qual é o código do livro que você quer buscar?: ");
                scanf("%d",&codigoBusca);
                pesquisarLivros(acervo, TAMANHO_ACERVO, codigoBusca);
                break;
            case 4: /** ordernar Livro */
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


void cadastrarLivros(struct Livro acervo[], int tamanho) {
    for (int i = 0; i < tamanho; i++) {

        printf("\n--- Cadastro do livro %d ---\n", i + 1);

        printf("Código: ");
        scanf("%d", &acervo[i].codigo);
        getchar(); // limpa o '\n' que sobra no buffer do scanf

        printf("Título: ");
        fgets(acervo[i].titulo, sizeof(acervo[i].titulo), stdin);
        acervo[i].titulo[strcspn(acervo[i].titulo, "\n")] = '\0'; // remove '\n'

        printf("Autor: ");
        fgets(acervo[i].autor, sizeof(acervo[i].autor), stdin); // endereço da array, quantos caracteres ele vai ler, entrada padrão do teclado
        acervo[i].autor[strcspn(acervo[i].autor, "\n")] = '\0'; // strcspn encontra a posição do \n e substitui por \0, limpando o final da string.

        printf("Ano: ");
        scanf("%d", &acervo[i].ano);
        getchar();

        printf("Área: ");
        fgets(acervo[i].area, sizeof(acervo[i].area), stdin);
        acervo[i].area[strcspn(acervo[i].area, "\n")] = '\0';

        printf("Editora: ");
        fgets(acervo[i].editora, sizeof(acervo[i].editora), stdin);
        acervo[i].editora[strcspn(acervo[i].editora, "\n")] = '\0';
    }
}

void imprimirLivros(struct Livro acervo[], int tamanho) {
    for (int i = 0; i < tamanho; i++) {
        printf("\n------------- LIVRO %d -------------\n", i + 1);
        printf("Código: %d\n", acervo[i].codigo);
        printf("Título: %s\n", acervo[i].titulo);
        printf("Autor: %s\n", acervo[i].autor);
        printf("Ano: %d\n", acervo[i].ano);
        printf("Área: %s\n", acervo[i].area);
        printf("Editora: %s\n", acervo[i].editora);
        printf("-----------------------------------\n");
    }
}

void pesquisarLivros(struct Livro acervo[], int tamanho, int codigoBusca){
    int i=0;
    // flag
    int encontrado = 0;

    while(i < tamanho){
        if(codigoBusca == acervo[i].codigo){
            printf("\n------------- LIVRO %d -------------\n", i + 1);
            printf("Código: %d\n", acervo[i].codigo);
            printf("Título: %s\n", acervo[i].titulo);
            printf("Autor: %s\n", acervo[i].autor);
            printf("Ano: %d\n", acervo[i].ano);
            printf("Área: %s\n", acervo[i].area);
            printf("Editora: %s\n", acervo[i].editora);
            printf("-----------------------------------\n");
            encontrado = 1; 
            break;            
        }
        i++;
    }
    if(!encontrado){
        printf("\nCódigo do livro não encontrado\n");
    }
}

void ordenarLivros(struct Livro acervo[], int tamanho) {
    struct Livro temp; // variável temporária para fazer trocas

    // Laço externo percorre todo o array
    for (int i = 0; i < tamanho - 1; i++) {
        // Laço interno percorre os elementos ainda não ordenados
        for (int j = 0; j < tamanho - i - 1; j++) {
            // Compara o ano de publicação de livros adjacentes
            if (acervo[j].ano > acervo[j + 1].ano) {
                // Troca de posição dos livros usando a variável temporária
                temp = acervo[j];
                acervo[j] = acervo[j + 1];
                acervo[j + 1] = temp;
            }
        }
    }
    printf("\nLivros ordenados por ano de publicação!\n");
}