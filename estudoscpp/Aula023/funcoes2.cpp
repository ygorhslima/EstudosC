#include <iostream>
using namespace std;
void soma(int n1, int n2);
void soma();

int main(){
    soma(10,20);
    soma();
}

void soma(int n1, int n2){
    int res = n1 + n2;
    cout << "a soma entre " << n1 << " e " << n2 << " é " << res << "\n";
}

void soma(){
    int n1 = 10;
    int n2 = 20;
    int res = n1 + n2;
    cout << "a soma entre " << n1 << " e " << n2 << " é " << res << "\n";
}