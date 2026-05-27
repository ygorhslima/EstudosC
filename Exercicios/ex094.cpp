/*
Crie um programa que vai ler vários números e colocar em uma lista.
Depois disso, crie duas listas extras que vão conter apenas os valores pares
e os valores ímpares digitados, respectivamente. Ao final, mostre o conteúdo das três listas

Digite um número: 7
Quer continuar? [S/N] s
Digite um número: 9
Quer continuar? [S/N] s
Digite um número: 2
Quer continuar? [S/N] s
Digite um número: 6
Quer continuar? [S/N] s
Digite um número: 8
Quer continuar? [S/N] n
-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
A lista completa é [7, 9, 2, 6, 8]
A lista de pares é [2, 6, 8]
A lista de ímpares é [7, 9]
*/

#include <iostream>
#include <list>
using namespace std;
int main()
{
    string resposta;
    int i, numero;
    list<int> lista_numero;
    list<int> lista_numero_pares;
    list<int> lista_numero_impares;

    while (resposta != "S" || resposta != "s")
    {
        cout << "Digite um número: ";
        cin >> numero;
        lista_numero.push_back(numero);

        if(numero % 2 == 0){
            lista_numero_pares.push_back(numero);
        }
        if(numero % 2 == 1){
            lista_numero_impares.push_back(numero);
        }

        cout << "Quer continuar? [S/N]: ";
        cin >> resposta;
        if (resposta == "N")
        {
            cout << "-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n";
            break;
        }
    }

    cout << "A lista completa é: ";
    cout << "[";
    for (int item : lista_numero) cout << " " << item << " ";
    cout << "]\n";

    cout << "A lista de pares é: ";
    cout << "[";
    for (int item : lista_numero_pares) cout << " " << item << " ";
    cout << "]\n";

    cout << "A lista de ímpares é: ";
    cout << "[";
    for (int item : lista_numero_impares) cout << " " << item << " ";
    cout << "]\n";

    

    return 0;
}