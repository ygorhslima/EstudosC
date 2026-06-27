#include <stdio.h>
#include <stdlib.h>
/*
 *
* 27) Crie um programa que leia duas notas de um aluno e calcule a sua média,
mostrando uma mensagem no final, de acordo com a média atingida:
- Média até 4.9: REPROVADO
- Média entre 5.0 e 6.9: RECUPERAÇÃO
- Média 7.0 ou superior: APROVADO
 */
int main() {
    float n1, n2, media;

    printf("Nota 1: ");
    scanf("%f", &n1);

    printf("Nota 2: ");
    scanf("%f", &n2);

    media = (n1 + n2) / 2;
    printf("Média: %.2f\n", media);

    if (media <= 4.9) {
        printf("Reprovado\n");
    }else if (media > 5.0 && media <= 6.9) {
        printf("Recuperação\n");
    }else if (media > 7.0) {
        printf("Aprovado\n");
    }

    return 0;
}