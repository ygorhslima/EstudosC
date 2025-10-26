/*
### Funções do `std::list`

**Construtores e Atribuição**
* **list()**: Constrói uma lista vazia.
* **operator=**: Atribui conteúdo de outra lista (cópia ou movimento).
* **assign()**: Apaga e substitui o conteúdo da lista por novos elementos.

**Iteradores**
* **begin()**: Retorna um iterador para o primeiro elemento.
* **end()**: Retorna um iterador para a posição após o último elemento.
* **rbegin()**: Retorna um iterador reverso para o último elemento.
* **rend()**: Retorna um iterador reverso para a posição antes do primeiro.
* **cbegin() / cend() / crbegin() / crend()**: Versões constantes dos iteradores (não permitem modificação).

**Acesso a Elementos**
* **front()**: Retorna uma referência ao **primeiro** elemento.
* **back()**: Retorna uma referência ao **último** elemento.

**Capacidade**
* **empty()**: Verifica se a lista está **vazia**.
* **size()**: Retorna o **número de elementos** na lista.
* **max_size()**: Retorna o tamanho máximo possível de elementos.

**Modificadores (Adicionar)**
* **push_front(val)**: Adiciona um elemento no **início** da lista
* **push_back(val)**: Adiciona um elemento no **final** da lista.
* **emplace_front(args)**: Constrói um elemento *in-place* no **início**.
* **emplace_back(args)**: Constrói um elemento *in-place* no **final**.
* **insert(pos, val)**: Insere um elemento **antes** da posição do iterador `pos`.
* **emplace(pos, args)**: Constrói um elemento *in-place* **antes** de `pos`.

**Modificadores (Remover)**
* **pop_front()**: Remove o elemento do **início**.
* **pop_back()**: Remove o elemento do **final**.
* **erase(pos)**: Remove o elemento na posição do iterador `pos`.
* **clear()**: Remove **todos** os elementos da lista.
* **swap(list& x)**: Troca o conteúdo da lista com o de outra lista `x`.
* **resize(n)**: Altera o número de elementos para $n$.

**Operações Específicas da Lista**
* **splice(pos, list& x)**: Transfere elementos da lista `x` para a lista atual **antes** de `pos` ($O(1)$).
* **remove(val)**: Remove **todas as ocorrências** do valor `val`.
* **remove\_if(pred)**: Remove elementos que satisfazem um **predicado** (função/lambda).
* **unique()**: Remove **elementos duplicados consecutivos**.
* **sort()**: **Ordena** os elementos da lista (usa algoritmo interno eficiente).
* **reverse()**: **Inverte** a ordem dos elementos.
* **merge(list& x)**: Combina a lista `x` com a atual (ambas devem estar ordenadas).
*/


#include <iostream>
#include <list>
using namespace std;

int main(){
    
    list<int> aula;
    list<int>::iterator it;
    int tam;
    
    aula.push_front(9);
    aula.push_front(8);
    aula.push_front(10);
    aula.push_front(50);
    aula.push_front(1);
    aula.push_front(5);
    aula.push_front(2);
    aula.push_front(4);
    aula.push_front(3);
    aula.push_front(7);
    aula.push_front(12);

    cout << "Tamanho da lista: " << aula.size() << "\n";

    tam = aula.size();
    aula.sort();
    for(int i=0; i < tam; i++){
        cout << aula.front() << "\n";
        aula.pop_front();
    }

    return 0;
}
