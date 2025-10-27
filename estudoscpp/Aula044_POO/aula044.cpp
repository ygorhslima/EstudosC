#include <iostream>
using namespace std;

class Aviao{
    public:
    string nome = "Azul";
    string tipo; 
    int vel = 0;
    int velMax;
    void ini(int tp);
};

void Aviao::ini(int tp){
    if(tp == 1){
        this->velMax = 800;
        this->tipo = "Jato";
    }else if(tp == 2){
        this->velMax = 350;
        this->tipo = "Monomotor";
    }else if(tp == 3){
        this->velMax = 180;
        this->tipo = "Planador";
    }
}



int main(){
    Aviao *avi = new Aviao();
    cout << avi->vel;
    cout << avi->nome;
    avi->ini(1);
    cout << avi->velMax;
    return 0;
}