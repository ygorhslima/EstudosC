#ifndef CLASSES_H_INCLUDED
#define CLASSES_H_INCLUDED

#include <iostream>
using namespace std;

class Veiculo {
public:
    int vel;
    int blind;
    int rodas;
private:
    int tipo;
    int velMax;
    bool arma;
};

class Moto:public Veiculo
{
    public: Moto();
}
Moto::Moto(){
    vel=0;
    blind=0;
    rodas=2;
    tipo=1;
}
#endif
