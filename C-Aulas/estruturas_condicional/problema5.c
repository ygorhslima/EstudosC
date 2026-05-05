#include <stdio.h>

int main()
{
    int op;
    float total;

    total = 0;
    printf("1 - italiano\n2 - japonês\n3 - Salvadorenho\n");
    printf("Informe o prato desejado: ");
    scanf("%d",&op);

    switch (op){
        case 1:
            total = total + 750;
            break;
        case 2:
            total = total + 324; 
            break;
        case 3:
            total = total  + 545;
            break;
        default:
            printf("informe o número correto");
            break;
    }

    printf("1 - Chá\n2 - Suco de Laranja\n3 - Refrigerante: \n");
    printf("informe a bebida desejada: \n");
    scanf("%d",&op);
    switch (op)
    {
        case 1:
            total = total + 30;
            break;
        case 2:
            total = total + 80;
            break;
        case 3:
            total = total + 90;
            break;
        default:
            break;
    }
    printf("o total de calorias é: %.2f \n",total);
    return 0;
}