#include <iostream>
#include <list>
#include <string>
#include <limits>

using namespace std;

typedef struct
{
    string nome;
    float peso;
} Dados;

int main()
{
    char continuar = 'S';
    list<Dados> lista_dados;
    list<Dados> lista_dados_maior_peso;
    list<Dados> lista_dados_menor_peso;
    float maiorPeso = 0;
    float menorPeso = numeric_limits<float>::max(); 

    // O loop roda ENQUANTO o usuário quiser continuar
    while (continuar == 'S' || continuar == 's')
    {
        Dados d;
        cout << "Nome: ";
        cin >> d.nome;
        cout << "Peso: ";
        cin >> d.peso;
        
        lista_dados.push_back(d);

        if (d.peso > maiorPeso)
        {
            maiorPeso = d.peso;
            lista_dados_maior_peso.clear();
            lista_dados_maior_peso.push_back(d);
        }
        else if (d.peso == maiorPeso)
        {
            lista_dados_maior_peso.push_back(d);
        }
        if (d.peso < menorPeso)
        {
            menorPeso = d.peso;
            lista_dados_menor_peso.clear();
            lista_dados_menor_peso.push_back(d);
        }
        else if (d.peso == menorPeso)
        {
            lista_dados_menor_peso.push_back(d);
        }
    
        cout << "Quer continuar? [S/N]: ";
        cin >> continuar;
        cout << "---------------------\n";
    }

    cout << "\nQuantidade de pessoas cadastradas: " << lista_dados.size() << "\n";
    
    cout << "Maior peso (" << maiorPeso << "kg): [ ";
    for (auto const& item : lista_dados_maior_peso) // 'auto' identifica o tipo Dados automaticamente
    {
        cout << item.nome << " ";
    }
    cout << "]\n";
    
    // C) Uma listagem com as pessoas mais leves
    cout << "Menor peso (" << menorPeso << "kg): [ ";
    for (auto const& item : lista_dados_menor_peso)
    {
        cout << item.nome << " ";
    }
    cout << "]\n";
    return 0;
}