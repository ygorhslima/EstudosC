/*
24) Faça um algoritmo que pergunte a distância que um passageiro deseja
percorrer em Km. Calcule o preço da passagem, cobrando R$0.50 por Km para
viagens até 200Km e R$0.45 para viagens mais longas.
*/

#include <stdio.h>
#include <stdlib.h>
int main(){
	float distancia;
	float preco;

	printf("quantos kms deseja percorrer?: ");
	scanf("%f", &distancia);
	if(distancia > 200){
		preco = distancia * 0.50;
	}else{
		preco = distancia * 0.45;
	}
	
	printf("o preço da passagem será de R$%.2f\n", preco);
	return 0;
}