#include <iostream>
#include "classes.h"
using namespace std;

int main(){
    Veiculo *v1 = new Veiculo(1);
    cout << v1->getVelMax() << "\n";
    Veiculo *v2 = new Veiculo(3);
    cout << v2->getVelMax() << "\n";
    Veiculo *v3 = new Veiculo(2);
    cout << v3->getVelMax() << "\n";
    return 0;
}
