#include <iostream>
using namespace std;

int main()
{
    /*um ponteiro armazena o endereço de memória de uma variável*/
    string veiculo = "Carro";
    string *pv;

    // ponteiro recebendo endereço de uma variável
    pv = &veiculo;

    *pv = "moto";

    cout << veiculo;
    return 0;
}