/*
23) Numa promoção exclusiva para o Dia da Mulher, uma loja quer dar descontos
para todos, mas especialmente para mulheres. Faça um programa que leia nome,
sexo e o valor das compras do cliente e calcule o preço com desconto. Sabendo
que:
- Homens ganham 5% de desconto
- Mulheres ganham 13% de desconto
*/
#include <stdio.h>
#include <stdlib.h>
int main()
{
	char nome[100];
	char sexo;
	float valor_compra;
	float desconto;

	printf("Nome: ");
	scanf("%[^\n]", nome);

	printf("Sexo[M/F]: ");
	scanf(" %c", &sexo);

	printf("valor da compra: ");
	scanf("%f", &valor_compra);

	if(sexo == 'M' || sexo == 'm'){
		desconto = valor_compra - (valor_compra * 0.05);
		printf("Olá %s, o seu valor da compra foi de R$%.2f e com desconto de 5%, seu preço foi para R$%.2f!\n", nome, valor_compra, desconto);
	}else if (sexo == 'F' || sexo == 'f'){
		desconto = valor_compra - (valor_compra * 0.13);
		printf("Olá %s, o seu valor da compra foi de R$%.2f e com desconto de 13%, seu preço foi para R$%.2f!\n", nome, valor_compra, desconto);
	}else{
		printf("ERRO! sexo somente [M/F]");
	}

	return 0;
}