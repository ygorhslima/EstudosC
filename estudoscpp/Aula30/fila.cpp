#include <iostream>
#include <queue>
using namespace std;

/*
FILA - QUEUE

====|   |=====
    |(3)|
    |(2)|
    |(1)|
    |   |

- O primeiro a ser adicionado é o primeiro a sair
- O último a ser adicionado é o último a sair

*/

int main(){

    queue<string> cartas; 
    
    cartas.push("Rei de Copas");
    cartas.push("Rei de Espadas");
    cartas.push("Rei de Ouros");
    cartas.push("Rei de Paus");
    
    cout << "tamanho da fila: " << cartas.size() << "\n";
    cout << "Primeira Carta.: " << cartas.front() << "\n";
    cout << "Última Carta...: " << cartas.back() << "\n\n";

    while(!cartas.empty()){
        cout << "primeira carta: " << cartas.front() << "\n";
        cartas.pop();
    }
    
    /**
     * funções:
     * empty()
     * size()
     * push()
     * pop()
     * 
     * específico do queue:
     * front() = primeiro item da fila
     * back() = último item da fila
     */
}