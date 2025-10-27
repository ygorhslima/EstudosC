#ifndef AVIAO_H_INCLUDED
#define AVIAO_H_INCLUDED

#include <iostream>
#include <string>
using namespace std;


class Aviao {
public:
    int vel = 0;
    int velMax;
    string tipo;
    Aviao(int tp);
    void imprimir();
};

Aviao::Aviao(int tp) {
    /* [1] Jato | [2] Monomotor | [3] Planador */
    if (tp == 1) {
        tipo = "Jato";
        velMax = 800;
    } else if (tp == 2) {
        tipo = "Monomotor";
        velMax = 350;
    } else if (tp == 3) {
        tipo = "Planador";
        velMax = 180;
    } else {
        tipo = "Desconhecido";
        velMax = 0;
    }
}

void Aviao::imprimir() {
    cout << "----------------------------------------\n";
    cout << "Tipo: " << tipo << "\n";
    cout << "Velocidade Máxima: " << velMax << " km/h\n";
    cout << "Velocidade Atual: " << vel << " km/h\n";
    cout << "----------------------------------------\n";
}

#endif
