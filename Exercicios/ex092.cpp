/*
    Digite um valor: 10
    adicionando na posição 0 da lista

    Digite um valor: 4
    Adicionando na posição 1 da lista

    Digite um valor: 30
    adicionando na posição 2 da lista

    Ordenando os valores: [4,10,30]
*/
#include <iostream>
#include <list>
using namespace std;
int main()
{
    int numero;
    int i;
    list<int> lista_numero;

    for (i = 0; i < 3; i++)
    {
        cout << "Digite um valor: ";
        cin >> numero;
        cout << "Adicionando na posição " << i << " da lista\n";
        lista_numero.push_back(numero);
    }

    cout << "[";
    for (int item : lista_numero)
    {
        cout << "," << item;
    }
    cout << "]";

    return 0;
}