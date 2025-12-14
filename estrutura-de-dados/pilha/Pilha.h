typedef int TipoItem;
using namespace std;
const int max_itens = 100;


class Pilha {
    private:
        int tamanho;
        // vetor 
        TipoItem* estrutura;   
    public:
        Pilha(); // construtora
        ~Pilha(); // destrutora
        // criando uma função para ver se a pilha está cheio ou não
        bool IsFull(); // verifica se a pilha está cheia
        bool IsEmpty(); // verifica se a pilha está vazia
        void Push(TipoItem item);
        TipoItem Pop();
        void Print();
        int Length();
};

Pilha::Pilha()
{
    tamanho = 0;
    estrutura = new TipoItem[max_itens]; 
}
    
Pilha::~Pilha()
{
    delete [] estrutura;
} 
    
bool Pilha::IsFull()
{
    return (tamanho == max_itens);
}

bool Pilha::IsEmpty()
{
    return (tamanho == 0);
}

void Pilha::Push(TipoItem item)
{
    if(IsFull()){
        cout << "A pilha está cheia\n";
    }else{
        estrutura[tamanho] = item;
        tamanho++;
    }
}

TipoItem Pilha::Pop()
{
    if(IsEmpty()){
        cout << "A pilha está vazia, não existe elementos para ser removido\n";
        return 0;
    }else{
        tamanho--;
        return estrutura[tamanho];
    }
}

void Pilha::Print()
{
    cout << "Pilha: [ ";
    for(int i = 0; i < tamanho; i++){
        cout << estrutura[i] << " ";
    }
    cout << "]\n";
}

int Pilha::Length(){
    return tamanho;
}
