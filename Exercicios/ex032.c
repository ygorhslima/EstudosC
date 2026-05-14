#include <stdio.h>

int main()
{
    float valorCasa, salario, prestacao;
    int anos, meses;

    printf("--- Sistema de Analise de Emprestimo ---\n");

    printf("Valor da casa: R$ ");
    scanf("%f", &valorCasa);
    printf("Salario do comprador: R$ ");
    scanf("%f", &salario);
    printf("Quantidade de anos para pagar: ");
    scanf("%d", &anos);

    meses = anos * 12;
    prestacao = valorCasa / meses;

    printf("\n--- Resultado ---\n");
    printf("Para pagar uma casa de R$ %.2f em %d anos,\n", valorCasa, anos);
    printf("a prestacao sera de R$ %.2f mensais.\n", prestacao);

    if (prestacao <= (salario * 0.30))
    {
        printf("SITUACAO: Emprestimo APROVADO!\n");
    }
    else
    {
        printf("SITUACAO: Emprestimo NEGADO!\n");
        printf("Motivo: A parcela excede 30%% do seu salario (R$ %.2f).\n", salario * 0.30);
    }

    return 0;
}