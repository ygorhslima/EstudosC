#include <iostream>
#include <stack>
using namespace std;

/*
PILHA - STACK

====|   |=====
    |(3)|
    |(2)|
    |(1)|
    |===|

- O primeiro a ser adicionado é o último a sair
- O último a ser adicionado é o primeiro a sair

*/


int main(){
    stack<string> cartas;

    if(cartas.empty()){
        cout << "pilha vazia\n\n";
    }else{
        cout << "pilhas com cartas\n\n";
    }

    cartas.push("Rei de Copas"); // último a sair
    cartas.push("Rei de Espadas");
    cartas.push("Rei de Ouros");
    cartas.push("Rei de Paus"); // primeiro a sair
    
    cout << "tamanho da pilha: " << cartas.size() << "\n";
    cout << "Carta do topo: " << cartas.top() << "\n";

    cartas.pop(); // retirada do elemento

    cout << "tamanho da pilha: " << cartas.size() << "\n";
    cout << "Carta do topo: " << cartas.top() << "\n";

    // push() = adiciona um valor da pilha
    // pop() = retira um valor da pilha
    // top() = mostra qual é o valor que está no topo
    // empty() = retorna verdadeiro ou falso caso a pilha estiver vazia

    return 0;
}