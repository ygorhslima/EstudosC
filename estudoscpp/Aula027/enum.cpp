#include <iostream>
using namespace std;

int main(){
    
    // o enum seria uma forma de colocar variáveis que tem algo em comum de forma mais simples
    // os valores são sequenciais por padrão
    enum armas{
        fuzil=100, 
        revolver=8,
        rifle=12,
        escopeta=1
    };

    armas armaSel;
    armaSel = fuzil;
    cout << armaSel;
    
    return 0;
}