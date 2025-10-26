#include <iostream>
using namespace std;

int main(){
    int n;
    // incremento
    n=0;
    while(n < 10){
        cout << n << "\n";
        n++;
    }

    cout << "\n";

    // decremento
    int cont = 20;
    while (cont > 0){
        cout << cont << "\n";
        cont--;
    }
    
    cout << "\n";

    // contagem dentro do while
    int j = 0;
    while(j++< 10){
        cout << j << "\n";
    }
    
    cout << "\n";


    return 0;
}