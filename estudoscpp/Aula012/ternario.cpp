#include <iostream>
using namespace std;

int main(){
    float n1,n2,nota;
    string res;

    cout << "Digite a primeira Nota: ";
    cin >> n1;
    cout << "Digite a segunda Nota:  ";
    cin >> n2;
    nota = n1 + n2;

    (nota >= 60) ? res="Aprovado" : res="Reprovado";
    cout << "situação do aluno: " << res << "\n";
    return 0;
}