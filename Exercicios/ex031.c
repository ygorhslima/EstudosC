//31) [DESAFIO] Crie um jogo de JoKenPo (Pedra-Papel-Tesoura)

#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    int jogador, computador;
    srand(time(NULL));
    printf("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= JOPENKO -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
    printf("Escolha uma das opções abaixo: \n");
    printf("[1] Pedra \n");
    printf("[2] Papel \n");
    printf("[3] Tesoura \n");
    printf("[0] Sair do Programa\n");
    printf("Digite sua opção: ");
    scanf("%d", &jogador);

    if (jogador == 0) {
        printf("saindo do programa...");
        return 0;
    }
    if (jogador < 1 || jogador > 3) {
        printf("ERRO! Escolha uma das opcoes do menu\n");
        return 0;
    }
    computador = (rand() % 3) + 1;
    char *opcoes[] = {"", "pedra", "papel", "tesoura"};
    printf("\nJogador escolheu: %s", opcoes[jogador]);
    printf("\nComputador escolheu: %s\n", opcoes[computador]);

    printf("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
    if (jogador == computador) {
        printf("EMPATE");
    }else if (
        (jogador == 1 && computador == 3) ||
        (jogador == 3 && computador == 2) ||
        (jogador == 2 && computador == 1)
    ) {
        printf("VOCÊ VENCEU");
    }else {
        printf("COMPUTADOR VENCEU");
    }
    printf("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

    return 0;
}