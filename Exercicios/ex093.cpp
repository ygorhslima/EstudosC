/*
Crie um programa que vai ler vários números e colocar em uma lista, depois disso, mostre
A) Quantos números foram digitados
B) A lista de valores, ordenada de forma decrescente
C) Se o valor 5 foi digitado e está ou não na lista
*/

#include <iostream>
#include <list>
using namespace std;

int main()
{
    int numero;
    list<int> lista_numero;
    string resposta;

    while (resposta != "S" || resposta != "s")
    {
        cout << "Digite um valor: ";
        cin >> numero;

        lista_numero.push_back(numero);

        cout << "Quer continuar [S/N]: ";
        cin >> resposta;

        if (resposta == "N")
        {
            cout << "Analisando os dados\n";
            break;
        }
    }
    lista_numero.reverse();
    cout << "quantos números foram digitados?: " << lista_numero.size() << "\n";
    cout << "Os valores ordenados de forma decrescente: [";
    for (int item : lista_numero)
    {
        cout << " " << item << " ";
    }
    cout << "]\n";

    cout << "O valor 5 está na lista?: ";
    for (int item : lista_numero)
    {
        if (item == 5)
        {
            cout << "sim\n";
            break;
        }
        else
        {
            cout << "Não\n";
            break;
        }
    }

    return 0;
}