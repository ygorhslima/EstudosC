/*
* 29) Desenvolva um programa que leia o nome de um funcionário, seu salário,
quantos anos ele trabalha na empresa e mostre seu novo salário, reajustado de
acordo com a tabela a seguir:
- Até 3 anos de empresa: aumento de 3%
- entre 3 e 10 anos: aumento de 12.5%
- 10 anos ou mais: aumento de 20%
 *
 */
#include <stdio.h>
#include <stdlib.h>

int main() {
    char nome_funcionario[50];
    float salario;
    int anos_empresa;
    float novo_salario;

    printf("Nome do funcionário: ");
    scanf("%[^\n]", nome_funcionario);

    printf("Salário: ");
    scanf("%f", &salario);

    printf("Anos de empresa: ");
    scanf("%d", &anos_empresa);

    // Lógica corrigida para cobrir todos os intervalos
    if (anos_empresa <= 3) {
        novo_salario = salario * 1.03; // Aumento de 3%
    }
    else if (anos_empresa < 10) {
        // Se caiu aqui, já sabemos que é maior que 3
        novo_salario = salario * 1.125; // Aumento de 12.5%
    }
    else {
        // Aqui entra quem tem 10 anos ou mais
        novo_salario = salario * 1.20; // Aumento de 20%
    }

    printf("\n--- Resultado do Reajuste ---\n");
    printf("Funcionario: %s\n", nome_funcionario);
    printf("Tempo de casa: %d anos\n", anos_empresa);
    printf("Novo salario: R$ %.2f\n", novo_salario);

    return 0;
}