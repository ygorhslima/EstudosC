#include <iostream>
using namespace std;

int main(){
    int l,c;
    int matriz[3][4];

    // adicionando valores na matriz
    for (l = 0; l < 3; l++){
        for(c = 0; c < 4; c++){
            matriz[l][c] = l;
        }
    }

    // mostrando valores da matriz
    for (l = 0; l < 3; l++){
        for(c = 0; c < 4; c++){
            cout << matriz[l][c] << " ";
        }
        cout << "\n";
    }

    return 0;
}