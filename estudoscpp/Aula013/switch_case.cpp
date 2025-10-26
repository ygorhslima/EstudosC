#include <iostream>
using namespace std;

int main(){
    int val, tom;
    cout << "selecione uma cor: \n";
    cout << "[1]Verde\n[2]Azul\n[3]Vermelho\n";
    cin >> val;

    switch(val)
    {
        case 1:
            cout << "\ncor selecionada: Verde\n";
            cout << "escolha agora os tons de verde:\n";
            cout << "[1]Verde claro\n[2]Verde escuro\n";
            cin >> tom;
            switch(tom){
                case 1:
                    cout << "você escolheu o tom: Verde claro\n";
                    break;
                case 2:
                    cout << "você escolheu o tom: Verde escuro\n";
                    break;
                default:
                    cout << "tom de cor inválido\n";
                    break;
            }
            break;
        case 2:
            cout << "cor selecionada: Azul";
            break;
        case 3:
            cout << "cor selecionada: Vermelho";
            break;
        default:
            cout << "valor selecionado inválido";
            break;
    }

    return 0;
}