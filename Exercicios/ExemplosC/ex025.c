/*
25) [DESAFIO] Crie um programa que leia o tamanho de três segmentos de reta.
Analise seus comprimentos e diga se é possível formar um triângulo com essas
retas. Matematicamente, para três segmentos formarem um triângulo, o comprimento
de cada lado deve ser menor que a soma dos outros dois.
*/
#include <stdio.h>
#include <stdlib.h>

int main(){
	float r1,r2,r3;
	
	printf("A: ");
	scanf("%f", &r1);
	
	printf("B: ");
	scanf("%f", &r2);

	printf("C: ");
	scanf("%f", &r3);

	if(r1 < r2 + r3 && r2 < r1 + r3 && r3 < r1 + r2){
		printf("os segmentos PODEM formar um triângulo\n");
	}else{
		printf("os segmentos NÃO PODEM formar um triângulo\n");
	}

	return 0;
}