#ifndef CLASSES_H_INCLUDED
#define CLASSES_H_INCLUDED

#include <iostream>
using namespace std;

class Veiculo {
public:
    int velMax;
    int tipo;
    Veiculo(int tp);
    /*criação dos métodos*/
    int getVelMax();
    void setVelMax(int vm);
private:
    string nome;
    int vel;
    bool ligado;
};

Veiculo::Veiculo(int tp) : vel(0), ligado(false)
{
    // 1 carro, 2 aviao, 3 navio
    tipo = tp;
    if (tipo == 1) {
        nome = "Carro";
        setVelMax(200);
    } else if (tipo == 2) {
        nome = "Aviao";
        setVelMax(800);
    } else if (tipo == 3) {
        nome = "Navio";
        setVelMax(120);
    } else {
        nome = "Desconhecido";
        setVelMax(0);
    }
}

int Veiculo::getVelMax(){
    return velMax;
}

void Veiculo::setVelMax(int vm){
    velMax=vm;
}

#endif
