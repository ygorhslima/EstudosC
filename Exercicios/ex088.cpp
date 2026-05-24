#include <iostream>
#include <random>
using namespace std;
int main(){
    int i;
    const int MAX = 5;
    
    int vetor_numeros_aleatorios[MAX];
    int computador;

    int maiorValor = 0;
    int menorValor = 0;
    

    // 2. Criamos o dispositivo de semente e o motor de geração (Mersenne Twister)
    random_device rd;
    mt19937 gen(rd());
    
    // 3. Definimos o intervalo dos números. Vamos simular de 1 a 100, por exemplo.
    uniform_int_distribution<> distr(1,100);

    cout << "Os valores sorteados foram: ";
    for(i = 0; i < MAX; i++){
        // 4. Sorteia um novo número e joga na variável 'computador'
        computador = distr(gen);
        vetor_numeros_aleatorios[i] = computador;
        
        if(i == 0){
            maiorValor = vetor_numeros_aleatorios[i];
            menorValor = vetor_numeros_aleatorios[i];
        }
        if(vetor_numeros_aleatorios[i] > maiorValor){
            maiorValor = vetor_numeros_aleatorios[i];
        }
        if(vetor_numeros_aleatorios[i] < menorValor){
            menorValor = vetor_numeros_aleatorios[i];
        }
        
        cout << vetor_numeros_aleatorios[i] << " ";
    }
    cout << "\n";
    cout << "O maior valor sorteado foi " << maiorValor << "\n";
    cout << "O menor valor sorteado foi " << menorValor << "\n";
    return 0;
}