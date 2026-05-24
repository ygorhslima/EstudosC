/*
Faça um programa que leia nome e peso de várias pessoas, guardando tudo em uma lista, no final mostre
A) quantas pessoas foram cadastrados
B) uma listagem com as pessoas mais pesadas
C) Uma listagem com as pessoas mais leves
*/
#include <iostream>
#include <string>
#include <list>
#include <climits> // Necessário para usar o maior valor possível no 'menor'
using namespace std;

struct Pessoa
{
    string nome;
    float peso;
};

int main()
{
    list<Pessoa> vetor;
    string nome;
    float peso;
    float maior = 0;
    float menor = 3.40282e+38;
    char resposta = 'S';

    while (resposta != 'N' && resposta != 'n')
    {
        cout << "Nome: ";
        cin >> nome;
        cout << "Peso: ";
        cin >> peso;

        Pessoa p = {nome, peso};
        vetor.push_back(p);

        if (peso > maior)
        {
            maior = peso;
        }
        if (peso < menor)
        {
            menor = peso;
        }
        cout << "Quer continuar [S/N]: ";
        cin >> resposta;
    }
    cout << "-=-=-=-=-=-=-=-=-=-=-=-=-=-==-=-=-=-=-=-=-=-=-=" << "\n";
    cout << "Ao todo, você cadastrou" << vetor.size() << "Pessoas\n";

    // B) Listagem das pessoas mais pesadas
    cout << "O maior peso foi de " << maior << "kg. Peso de: ";
    for (const auto &p : vetor)
    {
        if (p.peso == maior)
        {
            cout << "[ " << p.nome << " ]";
        }
    }
    cout << "\n";

    // C) Listagem das pessoas mais leves
    cout << "O menor peso foi de " << menor << "kg. Peso de: ";
    for (const auto &p : vetor)
    {
        if (p.peso == menor)
        {
            cout << "[ " << p.nome << " ] ";
        }
    }
    cout << "\n";

    return 0;
}