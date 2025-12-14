#include <iostream>
#include "Pilha.h"
using namespace std;


int main(){
    Pilha p1;
    TipoItem item;
    int opcao;
    cout << "programa gerador de pilha: \n";

    do {
        cout << "Digite 0 para parar o programa \n";
        cout << "Digite 1 para inserir um elemento\n";
        cout << "Digite 2 para remover um elemento\n";
        cout << "Digite 3 para imprimir a pilha\n";
        cin >> opcao;
        if (opcao == 1){
            cout << "Digite o elemento a ser inserido\n";
            cin >> item;
            p1.Push(item);
        }else if (opcao == 2){
            item = p1.Pop();
            cout << "Elemento Removido: " << item << endl;
        }else if (opcao == 3){
            p1.Print();
        }
    }while(opcao != 0);

    return 0;
}