#include <iostream>
#include <algorithm>
using namespace std;

int main()
{
    int i;
    const int MAX = 20;
    string listaTimesBrasileirao2026[MAX] = {
        "Palmeiras",
        "Flamengo",
        "Fluminense",
        "São Paulo",
        "Athletico-PR",
        "Bragantino",
        "Coritiba",
        "Bahia",
        "Botafogo",
        "EC Vitória",
        "Atlético-MG",
        "Internacional",
        "Vasco da Gama",
        "Cruzeiro",
        "Grêmio",
        "Santos",
        "Corinthians",
        "Mirassol",
        "Remo",
        "Chapecoense"};
    cout << "Lista de times do Brasileirão: \n";
    for (i = 0; i < MAX; i++)
    {
        cout << listaTimesBrasileirao2026[i] << "\n";
    }

    cout << "Os 5 primeiros são: \n";
    for (i = 0; i < 5; i++)
    {
        cout << listaTimesBrasileirao2026[i] << "\n";
    }

    cout << "Os 4 últimos são: \n";
    for (i = 16; i < MAX; i++)
    {
        cout << listaTimesBrasileirao2026[i] << "\n";
    }
    sort(listaTimesBrasileirao2026, listaTimesBrasileirao2026 + MAX);
    cout << "Times em ordem alfabética: \n";
    for (i = 0; i < MAX; i++)
    {
        cout << listaTimesBrasileirao2026[i] << "\n";
    }
    return 0;
}