#include <stdio.h>


int main(){
    float base1,base2,altura,area;
    printf("informe o valor da base maior: "); 
    scanf("%f",&base1);
    printf("informe o valor da base menor: ");
    scanf("%f",&base2);
    printf("informe o valor da altura: ");
    scanf("%f",&altura);
    area = ((base1 + base2) * altura) / 2;
    printf("\n a área do trapézio é: %.2f",area);
    return 0;
}