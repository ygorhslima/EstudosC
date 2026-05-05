#include <stdio.h>

/*
    a prefeitura de uma cidade está coletando informações sobre o salário e o número de filhos dos habitantes. A leitura de dados é realizada até que seja informado o valor -1 para o salário. Apresente a média de salário da população, a média de filhos e o maior salário
*/

int main(){
    float salario=0, soma_salario=0, soma_filhos=0, maior_salario=0;
    int nfilhos=0, npessoas=0;


    printf("informe o salário: R$");
    scanf("%f",&salario);
    
    while(salario != -1){
        printf("informe o número de filhos: ");
        scanf("%d",&nfilhos);
        npessoas++;
        
        // verificando o maior salário
        if(salario > maior_salario){
            maior_salario = salario; 
        }
        
        // incrementando a quantidade de filhos e a quantidade de salário
        soma_filhos = soma_filhos + nfilhos;
        soma_salario = soma_salario + salario;
        
        printf("informe o salário: R$");
        scanf("%f",&salario);
    }

    float media_salario = soma_salario / npessoas;
    float media_filhos = soma_filhos / npessoas;

    printf("A média de salários é: %.1f\n",media_salario);
    printf("A média de filhos é: %.1f\n",media_filhos);
    printf("O maior salário foi de R$%.1f\n",maior_salario);


    return 0;
}