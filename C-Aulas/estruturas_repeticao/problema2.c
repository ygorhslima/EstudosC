#include <stdio.h>

int main(){
    /**entrada de dados */
    /*
        nnota: quantidade de notas que será repetido
        soma: variável que vai armazenar as somas das notas dos alunos
        media: a média será = soma das notas / quantidade de notas
        naprovado: quantidade de aprovados
        nreprovado: quantidade de reprovados
        cod: código do Aluno, que será identificado no sistema
        i = incremento do for
        nota: as notas individuais do aluno que será acumulado somando a nota atual mais a nota anterior
    */
    float nota, soma,media;
    int cod, i, nnota, naprovado, nreprovado;
    naprovado = 0;
    nreprovado = 0;

    printf("informe o número de notas da disciplina");
    scanf("%d",&nnota);

    printf("Informe o código do Aluno: ");
    scanf("%d",&cod);

    while(cod != 0){
        soma = 0;
        for(int i = 0; i < nnota; i++){
            printf("informe a nota do aluno: ");
            scanf("%f",&nota);
            soma = soma + nota; // soma = nota anterior + nova nota
        }
        media = soma / nnota;
        if(media >= 6){ // se a nota for maior ou igual a 6 ele está aprovado, caso contrário reprovado
            naprovado++;
        }else{
            nreprovado++;
        }
        
        printf("Informe o código do Aluno: ");
        scanf("%d",&cod);
    }
    printf("O número e aprovados foi: %d\n",naprovado);
    printf("O número de reprovados foi: %d\n",nreprovado);

    return 0;
}