#include <stdio.h>

int main(){
    int vetorA[10];
    int i, indice_encontrado, busca;
    
    // 1. Leitura dos elementos
    for(i=0; i<10; i++){
        printf("digite o %d elemento: ", i);
        scanf("%d", &vetorA[i]);
    }

    // 2. Leitura do elemento a buscar
    printf("Informe o elemento que deseja buscar: "); 
    scanf("%d", &busca);
    
    // 3. Inicialização para a busca
    i = 0;
    indice_encontrado = -1; // Inicializa com -1 (valor inválido para índice)
    
    // 4. Loop de busca sequencial
    // O loop deve continuar enquanto não encontrar E não terminar o vetor.
    while((indice_encontrado == -1) && (i < 10)){
        if(vetorA[i] == busca) {
            indice_encontrado = i; // Armazena o índice onde encontrou
        }
        i++;
    }
    
    // 5. Bloco de impressão corrigido
    // Verifica se 'indice_encontrado' tem um valor válido (0 a 9)
    if(indice_encontrado != -1){
        printf("O elemento %d foi encontrado na posição %d.", busca, indice_encontrado);
    } else {
        printf("O elemento não foi encontrado.");
    }

    return 0;
}