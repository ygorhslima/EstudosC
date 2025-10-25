#include <iostream>
using namespace std;
int main(){
    
    // TIPO NOME;
    // TIPO NOME = VALOR;

    int vidas; // 20,40,60,100,-10
    char letra; // 'B'
    float decimal; // 2.5, 2.6 
    double decimal2; // 2.50000, 2.6810283
    bool vivo; // true / false
    string nome; // "Bruno"

    cout << "Digite o número de vidas: ";
    cin >> vidas;

    cout << "Digite uma letra: ";
    cin >> letra;

    cout << "Quanto de dinheiro : R$";
    cin >> decimal;

    cout << "Digite seu nome: ";
    cin >> nome;


    cout << "Nome: " << nome << "\n";
    cout << "Dinheiro: R$" << decimal << "\n";
    cout << "letra: " << letra << "\n";
    cout << "Vidas: " << vidas << "\n";


    return 0;
}