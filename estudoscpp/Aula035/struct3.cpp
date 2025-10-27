#include <iostream>
using namespace std;

struct Carro{
    string nome;
    string cor;
    int pot;
    int velMax;
    int vel;

    void inserirCarros(string p_nome, string p_cor, int p_pot, int p_velMax){
        nome=p_nome;
        cor=p_cor;
        pot=p_pot;
        velMax=p_velMax;
    }

    void mostrarCarros(){
        cout<<"\n---------------------------------------------\n";
        cout<<"Nome..............: "<< nome <<"\n";
        cout<<"Cor...............: "<< cor <<"\n";
        cout<<"Potência:.........: "<< pot <<" cavalos\n";
        cout<<"Velocidade Máxima.: "<< velMax <<"km/h\n";
        cout<<"\n---------------------------------------------\n";
    }

    void mudaVel(int mv){
        vel = mv;
        if(vel >= velMax){
            vel=velMax;
        }else if(vel < 0){
            vel = 0;
        }
    }
};

int main()
{
    Carro *carros = new Carro[4];
    Carro car1,car2,car3,car4;
    
    carros[0] = car1;
    carros[1] = car2;
    carros[2] = car3;
    carros[3] = car4;

    carros[0].inserirCarros("McQueen","Vermelho",750,320);
    carros[1].inserirCarros("The King","Azul",700,400);
    carros[2].inserirCarros("Chick Hicks","Verde",680,300);
    carros[3].inserirCarros("Mater","Marrom",800,600);
    
    for(int i=0;i < 4; i++){
        carros[i].mostrarCarros();
    }

    return 0;
}

