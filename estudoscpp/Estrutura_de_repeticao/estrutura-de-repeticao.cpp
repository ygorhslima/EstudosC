#include <iostream>
using namespace std;

int main(){
    float n1=0, n2=0, res=0;
    for(int i = 0; i<4; i++){
        cout << "\n------------------------------------\n";
        if(n1 < 0 && n2 < 0){
            cout << "\nnão pode ter valores negativos na nota\n";
            n1=0;
            n2=0;
            break;
        }else{
            cout << "\nnota1: ";
            cin >> n1;
            cout << "\nnota2: ";
            cin >> n2;
            res = (n1 + n2) / 2;
            cout << "\no resultado foi \n" << res;
            cout << "\n------------------------------------\n";
        }
    }
    
    return 0;
}