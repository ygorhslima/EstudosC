#include <iostream>
#include <list>
#include <algorithm> // Necessário para usar o 'find'

using namespace std;

int main() {
    int numero;
    char resposta; // Mudei para char para facilitar a validação de S/N
    list<int> lista_numeros;

    while (true) {
        cout << "Digite um valor: ";
        cin >> numero;

        // VERIFICAÇÃO DE DUPLICADOS:
        // O std::find busca o número do início ao fim da lista.
        // Se ele chegar ao fim (lista_numeros.end()) significa que o número NÃO existe na lista.
        if (find(lista_numeros.begin(), lista_numeros.end(), numero) == lista_numeros.end()) {
            lista_numeros.push_back(numero);
            cout << "Valor adicionado com sucesso...\n";
        } else {
            cout << "Valor duplicado! Nao vou adicionar...\n";
        }

        cout << "Quer continuar [S/N]: ";
        cin >> resposta;

        // Se o usuário digitar 'N' ou 'n', o laço quebra
        if (resposta == 'N' || resposta == 'n') {
            break;
        }
    }

    // ORDENAÇÃO:
    // A estrutura std::list possui um método próprio para ordenar seus elementos
    lista_numeros.sort();

    // COMO OBTER E EXIBIR OS DADOS DA LISTA:
    // Usamos o "Range-based for loop" (disponível desde o C++11). 
    // Ele lê cada elemento da lista automaticamente, sem precisar de índices.
    cout << "\nVoce digitou os valores: [";
    bool primeiro = true;
    for (int num : lista_numeros) {
        if (!primeiro) {
            cout << ", ";
        }
        cout << num;
        primeiro = false;
    }
    cout << "]\n";

    return 0;
}