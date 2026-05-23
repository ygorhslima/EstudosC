#include <iostream>
#include <string> // É bom incluir a biblioteca string explicitamente

using namespace std;

int main()
{
    int numero;
    string numerosEmPalavrasAte20[21] = {
        "zero", "um", "dois", "três", "quatro", "cinco",
        "seis", "sete", "oito", "nove", "dez", "onze", "doze",
        "treze", "quatorze", "quinze", "dezesseis", "dezessete",
        "dezoito", "dezenove", "vinte"
    };
    cout << "Digite um número entre 0 e 20: ";
    cin >> numero;

    if (numero >= 0 && numero <= 20)
    {
        cout << "Você digitou o número " << numerosEmPalavrasAte20[numero] << endl;
    }
    else
    {
        cout << "Número inválido! Precisa ser entre 0 e 20." << endl;
    }

    return 0;
}