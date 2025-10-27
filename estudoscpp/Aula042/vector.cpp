#include <stdio.h>
#include <vector>
#include <stdlib.h>
using namespace std;

int main(){
    vector<int> num,num2;
    int tam, i;
    num.push_back(10);
    num.push_back(2);
    num.push_back(5);
    num.push_back(8);
 
    num2.push_back(20);
    num2.push_back(4);
    num2.push_back(10);
    num2.push_back(40);
    num2.push_back(50);
    
    num.swap(num2); // troca de valores

    tam = num.size();

    printf("tamanho do vector: %d\n", tam);
    printf("Primeiro valor de num: %d\n",num.front());
    printf("valor do meio de num: %d\n",num.at(tam/2));
    printf("Último valor de num: %d\n",num.back());

    for(i=0;i<tam;i++){
        printf("%d\n",num[i]);
    }

    return 0;
}