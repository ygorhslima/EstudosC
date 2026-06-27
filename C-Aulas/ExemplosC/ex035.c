#include <stdio.h>

int main() {
    int opcao_carro, dias_aluguel;
    float km_percorridos, total;

    printf("Qual o tipo de carro Alugado?: \n");
    printf("[1] Popular\n");
    printf("[2] Luxo\n");
    printf("Escolha a opção: ");
    scanf("%d", &opcao_carro);

    printf("Quantos dias de aluguel?: ");
    scanf("%d", &dias_aluguel);

    printf("Quantos km percorridos?: ");
    scanf("%f", &km_percorridos);

    switch (opcao_carro) {
        case 1:
            // Carro Popular: R$90/dia
            if (km_percorridos <= 100) {
                total = (dias_aluguel * 90) + (km_percorridos * 0.20);
            } else {
                total = (dias_aluguel * 90) + (km_percorridos * 0.10);
            }
            printf("\n--- Recibo Carro Popular ---\n");
            break;

        case 2:
            // Carro de Luxo: R$150/dia
            if (km_percorridos <= 200) {
                total = (dias_aluguel * 150) + (km_percorridos * 0.30);
            } else {
                total = (dias_aluguel * 150) + (km_percorridos * 0.25);
            }
            printf("\n--- Recibo Carro de Luxo ---\n");
            break;

        default:
            printf("\nERRO! Escolha a opção 1 ou 2.\n");
            return 1; // Encerra o programa com erro
    }

    printf("Total de dias: %d\n", dias_aluguel);
    printf("Km rodados: %.2f\n", km_percorridos);
    printf("Preço total a pagar: R$ %.2f\n", total);

    return 0;
}