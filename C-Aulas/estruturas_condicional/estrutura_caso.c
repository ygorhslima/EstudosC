#include <stdio.h>
#include <math.h>
/**
 * 
 *  construiremos um programa que permita ao usuário escolher qual
operação deseja realizar com dois números (1 – soma, 2 – subtração, 3 – multiplicação
e 4 – divisão). Precisamos de duas variáveis para armazenar cada um dos números:
uma para armazenar a operação selecionada pelo usuário, e outra para armazenar o
resultado da operação. Deste modo, temos a declaração de três variáveis do tipo float
(num1, num2 e resultado) e uma variável do tipo int (op).
 */
int main(){
    float num1, num2, resultado;
    int op;
    printf("informe um número: ");
    scanf("%f",&num1);
    printf("informe outro número: ");
    scanf("%f",&num2);
    
    printf("\n------------------OPERAÇÕES------------------\n");
    printf("[ 1 ]SOMA\n");
    printf("[ 2 ]SUBTRAÇÃO\n");
    printf("[ 3 ]MULTIPLICAÇÃO\n");
    printf("[ 4 ]DIVISÃO\n");
    printf("escolha uma opção: ");
    scanf("%d",&op);

    switch(op){
        case 1:
            resultado = num1 + num2;
            break;
        case 2:
            resultado = num1 - num2;
            break;
        case 3:
            resultado = num1 * num2;
            break;
        case 4:
            if((num1 != 0) && (num2 != 0)){
                resultado = num1 / num2;
            }else{
                printf("não é possível dividir um valor nulo\n");
                return 0;
            }
            break;
        default:
            printf("informe uma das opções que está no menu\n");
            return 0;
    }
    printf("o resultado do calculo foi %.2f\n",resultado);
    return 0;
}