#include <stdio.h>
using namespace std;

int main(){
    float n1,n2,n3,n4,media;
    
    printf("nota1: "); scanf("%f",&n1);
    printf("nota2: "); scanf("%f",&n2);
    printf("nota3: "); scanf("%f",&n3);
    printf("nota4: "); scanf("%f",&n4);

    media = (n1+n2+n3+n4) / 4;
    printf("a média foi: %.2f\n", media);

    if(media >= 6){
       printf("aprovado\n"); 
    }else if(media >= 5 && media < 6){
        printf("recuperação\n");
    }else{
        printf("reprovado\n");
    }

    return 0;
}
