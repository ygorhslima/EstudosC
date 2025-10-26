#include <iostream>
using namespace std;

struct Carro{
    string nome;
    string cor;
    int pot;
    int velMax;
};

int main()
{
    /*struct é uma criação de um novo tipo, é parecido com Classes do POO, porém mais primitivas, com variáveis e funções, como no POO para atributos e métodos*/

    Carro car1;
    car1.nome = "McQueen";
    car1.cor = "Vermelho";
    car1.pot = 380;
    car1.velMax = 510;
    
    cout<<"\n---------------------------------------------\n";
    cout<<"Nome..............: "<<car1.nome<<"\n";
    cout<<"Cor...............: "<<car1.cor<<"\n";
    cout<<"Potência:.........: "<<car1.pot<<" cavalos\n";
    cout<<"Velocidade Máxima.: "<<car1.velMax<<"km/h\n";
    cout<<"\n---------------------------------------------\n";

    return 0;
}