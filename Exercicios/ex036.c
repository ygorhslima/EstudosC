#include <stdio.h>
#include <stdlib.h>
/*
36) Um programa de vida saudável quer dar pontos atividades físicas que podem
ser trocados por dinheiro. O sistema funciona assim:
- Cada hora de atividade física no mês vale pontos
- até 10h de atividade no mês: ganha 2 pontos por hora
- de 10h até 20h de atividade no mês: ganha 5 pontos por hora
- acima de 20h de atividade no mês: ganha 10 pontos por hora
- A cada ponto ganho, o cliente fatura R$0,05 (5 centavos)
*/
int main()
{      
    int horas;
    float pontos, faturamento;    
    printf("-=-=-=-=-=-=-Sistema de vida saudável-=-=-=-=-=-=-\n");
    
    printf("Digite as horas de atividade física no mês: ");
    scanf("%d", &horas);

    if(horas <= 10){
        pontos = horas * 2;
    }else if (horas > 10 && horas <= 20){
        pontos = horas * 5;
    }else{
        pontos = horas * 10;
    }
    
    faturamento = pontos * 0.05;
    printf("Você praticou no mês %d horas\n", horas);
    printf("Você ganhou %.1f pontos\n", pontos);
    printf("A cada ponto ganho, você vai ganhar R$%.1f\n", faturamento);

    return 0;
}