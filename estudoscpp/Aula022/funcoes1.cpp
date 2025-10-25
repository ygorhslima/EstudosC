#include <iostream>
using namespace std;

/**prototipando/apresentando a função */
void texto();
void soma(int n1,int n2);
int soma2(int n1, int n2);
void tr(string tra[4]);

int main(){
    string transp[4] = {"carro","moto","caminhao","aviao"};
    tr(transp);

    soma(10,10);
    int res = soma2(170,200);
    cout << "valor de res: " << res << "\n";
    return 0;
}


void texto(){
    cout << "olá mundo\n";
}
void soma(int n1, int n2){
    cout << "A soma entre " << n1 << " e " << n2 << " é " << n1+n2 << "\n";
}
// com retorno
int soma2(int n1, int n2){
    return n1+n2;
}
void tr(string tra[4]){
    for(int i = 0; i < 4; i++){
        cout << tra[i] << "\n";
    }
}