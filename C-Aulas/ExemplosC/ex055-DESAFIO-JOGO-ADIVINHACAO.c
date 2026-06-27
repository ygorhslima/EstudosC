/*[DESAFIO] criação de um jogo de adivinhação, o computador vai sortear um número entre 1 e 10 e o jogador vai ter 4
tentativas para tentar acertar.*/

#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main()
{
    int jogador;
    int computador;
    srand(time(NULL));
    for (int i = 1; i <= 4; i++)
    {
        printf("\n=====================JOGO DA ADIVINHAÇÃO=====================\n");
        printf("Vou pensar em um número entre 1 e 10, quero que você tente adivinhar que número eu pensei\n");

        // processamento
        computador = rand() % 10 + 1;
        // =======================

        printf("Qual número eu pensei?: ");
        scanf("%d", &jogador);

        if (jogador == computador)
        {
            printf("Você acertou, eu pensei no número %d\n", jogador);
        }
        else
        {
            printf("você errou, eu pensei no número %d e não %d\n", computador, jogador);
        }
    }
}