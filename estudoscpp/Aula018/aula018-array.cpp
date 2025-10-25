#include <iostream>

using namespace std;

int main(){
    int i;
    int tam = 10;
    int vetor[tam] = {10,20,30,40,50,60,70,80,90,100};
    
    for(i = 0; i < tam; i++){
        cout << vetor[i] << "\n";
    }

    return 0;
}