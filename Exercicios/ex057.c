/*
57) Desenvolva um aplicativo que leia o salário e o sexo de vários funcionários.
No final, mostre o total de salários pagos aos homens e o total pago às
mulheres. O programa vai perguntar ao usuário se ele quer continuar ou não
sempre que ler os dados de um funcionário.
*/

#include <stdio.h>
#include <stdlib.h>

int main()
{
    float salario;
    char sexo;
    int totSalariosPagoHomens = 0;
    int totSalarioPagoMulheres = 0;

    char resposta;

    while (resposta != 'N')
    {
        printf("Salário: R$");
        scanf("%f", &salario);

        printf("Sexo[M/F]: ");
        scanf(" %c", &sexo);

        if (sexo == 'M' || sexo == 'm')
        {
            totSalariosPagoHomens += salario;
        }
        if (sexo == 'F' || sexo == 'f')
        {
            totSalarioPagoMulheres += salario;
        }

        printf("Quer continuar [S/N]: ");
        scanf("%s", &resposta);

        if(resposta == 'N'){
            printf("verificando as informações...\n");
            break;
        }
    }
    printf("=================== RESULTADO ====================\n");
    printf("o total de salários pago dos homens foi: R$%d\n", totSalariosPagoHomens);
    printf("o total de salários pago dos mulheres foi: R$%d\n", totSalarioPagoMulheres);
    printf("==================================================\n");

    return 0;
}