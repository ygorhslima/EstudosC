#include <iostream>
using namespace std;

int main(){
    int idade;
    /*teste lógico: > , <, >= , <= , ==, !=*/
    cout << "digite sua idade: ";
    cin >> idade;

    if(idade > 18){
        cout << "você é um adulto\n";
    }else{
        cout << "você é menor de idade\n";
    }

    if(100 > (50*2)){
        cout << "o valor 100 tem em sua comparação é maior que o valor que está sendo multiplicado\n";
    }else{
        cout << "o valor 100 tem em sua comparação um valor igual a ele\n";
    }

    bool sol = true;
    if(sol){
        cout << "vou a praia\n";
    }else{
        cout << "vou ficar em casa assistindo netflix\n";
    }

    return 0;
}