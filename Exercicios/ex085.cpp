/*
85) Faça um algoritmo que leia o nome, o sexo e o salário de 5 funcionários e
guarde esses dados em três vetores. No final, mostre uma listagem contendo
apenas os dados das funcionárias mulheres que ganham mais de R$5 mil.
*/

#include <iostream>
#include <string>
using namespace std;
int main()
{
    const int MAX = 5;
    string nome;
    char sexo;
    float salario;

    string vetor_nome[MAX];
    char vetor_sexo[MAX];
    float vetor_salario[MAX];

    int i;
    for (i = 0; i < MAX; i++)
    {
        cout << "\n================°" << i << " Pessoa " << "================\n";

        cout << "nome: ";
        cin >> nome;

        cout << "sexo[M/F]: ";
        cin >> sexo;

        cout << "salário: R$";
        cin >> salario;

        vetor_nome[i] = nome;
        vetor_sexo[i] = sexo;
        vetor_salario[i] = salario;
    }

    cout << "\n================DADOS DE MULHERES QUE GANHAM ACIMA DE R$5000================\n";
    for (i = 0; i < MAX; i++)
    {
        // dados das funcionárias mulheres que ganham mais de R$5 mil.
        if ((vetor_sexo[i] == 'F' || vetor_sexo[i] == 'f') && vetor_salario[i] > 5000)
        {
            cout << "Nome: " << vetor_nome[i] << "\n";
            cout << "salário: R$" << vetor_salario[i] << "\n";
        }
    }

    return 0;
}