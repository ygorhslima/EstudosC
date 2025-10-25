#include <iostream>
using namespace std;

// variável de escopo global pode ser usada em todas as partes do código
int n1,n2; // variável global

// operadores matemáticos: +, -, /, *, %, ()
int main(){
    // variável de escopo local só pode ser utilizada dentro de uma estrutura
    int n3,n4; // variável local
    int res;
    n1=11;
    n2=3;
    n3=5;
    n4=2;

    res = n1+n2*n4;
    cout << "valor de res: " << res;
    return 0;
}