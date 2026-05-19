/*
Crie um algoritmo que leia a idade de 10 pessoas, mostrando no final:
a) Qual é a média de idade do grupo
b) Quantas pessoas tem mais de 18 anos
c) Quantas pessoas tem menos de 5 anos
d) Qual foi a maior idade lida
*/

#include <stdio.h>
#include <stdlib.h>

int main(){
    int idade, somaIdade, cont, mediaGrupo, pessoaMais18Anos, pessoasMenos5Anos, maiorIdade;
    
    for(int i = 1; i <= 10; i++){
        printf("Digite a idade da °%d pessoa: ", i);
        scanf("%d", &idade);

        somaIdade += idade;

        if(i == 1){
            maiorIdade = idade;
        }
        if(idade > 18){
            pessoaMais18Anos++;
        }
        if(idade < 5){
            pessoasMenos5Anos++;
        }
        if(idade > maiorIdade){
            maiorIdade = idade;
        }
        cont++;
    }
    mediaGrupo = somaIdade / cont;

    printf("Quantidade de pessoas com mais 18 anos: %d\n", pessoaMais18Anos);
    printf("Quantidade de pessoas com menos de 5 anos: %d\n", pessoasMenos5Anos);
    printf("A pessoa com a maior idade foi %d\n", maiorIdade);
    printf("A média de idade do grupo é %d\n", mediaGrupo);
    return 0;
}