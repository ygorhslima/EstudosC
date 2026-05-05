#include <stdio.h>
/**
 * Em uma avaliação de um produto, o cliente responde sua opinião
 * 1 - satisfatório \n2 - indiferente\n3 - insatisfatório 
 * ENTRADA DE DADOS
 * 
 * - ler a idade
 * - ler a opinião
 * 
 * SAÍDA DE DADOS
 *
 * - apresente o número de clientes que responderam satisfatório
 * - média de idade dos cliente que opinaram como satisfatório
 * - o número de clientes que responderam insatisfatório 
 * 
 * condição de parada: quando o cliente digitar o valor zero para idade
 
 */

int main(){
    int idade, opiniao, n_clientes;
    int n_clientes_satisfatorios, n_clientes_indiferente, n_clientes_insatisfatorio;
    float soma_idade, media_idade;

    n_clientes = 0;
    n_clientes_satisfatorios = 0;
    n_clientes_insatisfatorio = 0;
    n_clientes_indiferente = 0;


    printf("informe sua idade: ");
    scanf("%d",&idade);

    while(idade != 0){
        printf("\n----------------------- MENU -----------------------\n");
        printf("1 - satisfatório \n2 - indiferente\n3 - insatisfatório\n");
        
        do{
            printf("dê sua opinião: ");
            scanf("%d",&opiniao);
        }while((opiniao!=1) && (opiniao!=2) && (opiniao != 3));

        n_clientes++;

        switch (opiniao)
        {
            case 1:  // satisfatório
                soma_idade = soma_idade + idade;
                n_clientes_satisfatorios++;
                break;
            case 2:
                printf("opinião indiferente");
                n_clientes_indiferente++;
                break;
            case 3: // insatisfeito
                n_clientes_insatisfatorio++;
                break;
            default:
                printf("impossível você ter errado!");
                break;
        }    
        
        printf("informe sua idade: ");
        scanf("%d",&idade);
    }

    media_idade = soma_idade / n_clientes;

    printf("O número de pessoas insatisfeitas é: %d\n",n_clientes_insatisfatorio);
    printf("O número de pessoas satisfeitas é: %d\n",n_clientes_satisfatorios);
    printf("A média de idade das pessoas satisfeitas é: %.2f\n",media_idade);

    return 0;
}