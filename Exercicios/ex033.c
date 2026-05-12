#include <stdio.h>
#include <stdlib.h>

struct notas {
    double bim1;
    double bim2;
    double bim3;
    double bim4;
};
struct notas alunos_nota[40];

int main() {
    alunos_nota[0].bim1 = 7.5;
    alunos_nota[0].bim2 = 8.5;
    alunos_nota[0].bim3 = 9.5;
    alunos_nota[0].bim4 = 10.5;

    return 0;
}