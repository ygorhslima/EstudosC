#include <iostream>

using namespace std;

int main(){
    int n1,n2,res;
    char opc;
    



    cout << "digite o valor da nota 1: "; cin >> n1;
    cout << "digite o valor da nota 2: "; cin >> n2;
    res=n1+n2;

    if(res >= 60){
        cout << "\nAluno Aprovado\n";
    }else if(res >= 40){
        cout << "\nAluno em Recuperação\n";
    }else{
        cout << "Aluno Reprovado";
    }

    return 0;
}