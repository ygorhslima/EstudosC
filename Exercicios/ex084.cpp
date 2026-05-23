/*
84) Crie um programa que leia o nome e a idade de 9 pessoas e guarde esses
valores em dois vetores, em posições relacionadas. No final, mostre uma listagem
contendo apenas os dados das pessoas menores de idade.
*/

#include <iostream>
#include <string>
using namespace std;

int main()
{
    const int MAX = 9;
    int i;

    string nome;
    int idade;

    string vetor_nome[MAX];
    int vetor_idade[MAX];

    for (i = 0; i < MAX; i++)
    {
        cout << "digite um nome: ";
        cin >> nome;

        cout << "digite sua Idade: ";
        cin >> idade;

        vetor_nome[i] = nome;
        vetor_idade[i] = idade;
    }

    cout << "\n================================\n";
    cout << "DADOS: \n";
    for (i = 0; i < MAX; i++)
    {
        cout << " -> " << vetor_nome[i] << ", " << vetor_idade[i] << "\n";
    }
    cout << "\n============================\n";

    cout << "\n================================\n";
    cout << "Pessoas menores de idade: \n";
    for (i = 0; i < MAX; i++)
    {
        if (vetor_idade[i] < 18)
        {
            // Aqui você puxa o nome e a idade usando o mesmo índice [i]
            cout << "Nome: " << vetor_nome[i] << " - Idade: " << vetor_idade[i] << "\n";
        }
    }
    cout << "\n============================\n";

    return 0;
}