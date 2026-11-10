Aqui estão as principais estruturas de dados do C# explicadas com exemplos práticos de código. Array, List, LinkedList, Queue, Stack, Dictionary e HashSet
### 1. Estruturas Lineares (Sequenciais)

#### Array (`T[]`)
Coleção de tamanho fixo. Ideal quando você já sabe a quantidade exata de elementos.
```cs
// Declara e inicializa um array com 3 posições
string[] diasDaSemana = { "Segunda", "Terça", "Quarta" };
Console.WriteLine(diasDaSemana[0]); // Saída: Segunda
```
#### List (`List<T>`)

Lista dinâmica que cresce ou diminui conforme necessário. É a estrutura mais usada no dia a dia.

```cs
List<string> frutas = new List<string> { "Maçã", "Banana" };
frutas.Add("Laranja"); // Adiciona um novo item
frutas.Remove("Banana"); // Remove o item
Console.WriteLine(frutas.Count); // Saída: 2
```

#### LinkedList (`LinkedList<T>`)

Lista duplamente encadeada. Cada elemento sabe quem é o anterior e o próximo, excelente para inserções rápidas no meio.
```cs
LinkedList<string> playlist = new LinkedList<string>();
var primeiro = playlist.AddFirst("Música A");
playlist.AddAfter(primeiro, "Música B"); // Insere após a música A
```
#### Queue (`Queue<T>`)

Estrutura **FIFO** (_First In, First Out_). O primeiro a entrar é o primeiro a sair (como uma fila de banco).
```cs
Queue<string> filaAtendimento = new Queue<string>();
filaAtendimento.Enqueue("Cliente 1");
filaAtendimento.Enqueue("Cliente 2");

string proximo = filaAtendimento.Dequeue(); // Remove e retorna "Cliente 1"
```

#### Stack (`Stack<T>`)

Estrutura **LIFO** (_Last In, First Out_). O último a entrar é o primeiro a sair (como uma pilha de pratos ou o botão _Desfazer_).

```cs
Stack<string> historicoNavegacao = new Stack<string>();
historicoNavegacao.Push("PaginaHome");
historicoNavegacao.Push("PaginaPerfil");

string ultimoVisitado = historicoNavegacao.Pop(); // Retorna "PaginaPerfil"
```

### 2. Estruturas Baseadas em Chave-Valor

#### Dictionary<TKey, TValue> (`Dictionary<TKey, TValue>`)

Armazena pares de chave e valor para buscas extremamente rápidas por chave.

```cs
Dictionary<int, string> funcionarios = new Dictionary<int, string>();
funcionarios.Add(101, "Carlos");
funcionarios.Add(102, "Mariana");

Console.WriteLine(funcionarios[101]); // Saída: Carlos
```

### 3. Estruturas Baseadas em Conjuntos

#### HashSet (`HashSet<T>`)

Coleção de elementos **únicos** (sem duplicatas) com alta performance para operações de conjunto (união, intersecção).
```cs
HashSet<string> permissoes = new HashSet<string> { "Leitura", "Escrita" };
bool adicionou = permissoes.Add("Leitura"); // Retorna false, pois já existe!
```

# Métodos usados nas coleções

As coleções e estruturas de dados no ecosistema .NET (C#) possuem métodos específicos otimizados para seus propósitos de armazenamento e manipulação. Abaixo estão os principais métodos de cada uma delas:
## 1. Array (Vetor) 

Na página de Arrays eu detalho todos eles [[06 - Arrays e Matrizes]]
## 2. List (Lista Dinâmica)

Uma lista redimensionável que permite acesso por índice e opera muito como um array dinâmico.
- **`Add(item)`**: Adiciona um item ao final da lista.
- **`AddRange(colecao)`**: Adiciona os elementos de outra coleção ao final.
- **`Insert(indice, item)`**: Insere um item em uma posição específica.
- **`Remove(item)`**: Remove a primeira ocorrência de um item específico.
- **`RemoveAt(indice)`**: Remove o item localizado em um índice específico.
- **`Contains(item)`**: Retorna `true` se o item existir na lista.
- **`IndexOf(item)`**: Retorna o índice da primeira ocorrência do item.
- **`Sort()`**: Ordena os elementos da lista.
- **`Find(match)` / `FindAll(match)`**: Busca elementos usando uma condição (predicado).
- **`Clear()`**: Remove todos os elementos.

## 3. LinkedList (Lista Duplamente Ligada)

Cada nó aponta para o anterior e o seguinte, ideal para inserções e remoções rápidas no início ou meio se você já tiver a referência do nó.

- **`AddFirst(item)`**: Adiciona um elemento no início da lista.
- **`AddLast(item)`**: Adiciona um elemento no final da lista.
- **`AddBefore(no, item)`**: Adiciona um novo nó antes de um nó de referência.
- **`AddAfter(no, item)`**: Adiciona um novo nó depois de um nó de referência.
- **`Remove(item)` / `Remove(no)`**: Remove o primeiro elemento correspondente ou o nó específico.
- **`Find(item)`**: Busca o primeiro nó que contém o valor especificado.
- _Propriedades principais:_ `First`, `Last`, `Next`, `Previous`.
## 4. Queue (Fila - FIFO: First In, First Out)

Segue o princípio de que o primeiro elemento a entrar é o primeiro a sair.
- **`Enqueue(item)`**: Adiciona um item ao final da fila.
- **`Dequeue()`**: Remove e retorna o item que está no início da fila.
- **`Peek()`**: Retorna o item do início da fila **sem** removê-lo.
- **`Contains(item)`**: Verifica se o item está presente na fila.
- **`Clear()`**: Limpa todos os elementos da fila.


## 5. Stack (Pilha - LIFO: Last In, First Out)

Segue o princípio de que o último elemento a entrar é o primeiro a sair.
- **`Push(item)`**: Insere um item no topo da pilha.    
- **`Pop()`**: Remove e retorna o item que está no topo da pilha.
- **`Peek()`**: Retorna o item do topo **sem** removê-lo.
- **`Contains(item)`**: Verifica se o item está na pilha.
- **`Clear()`**: Limpa todos os elementos da pilha.

## 6. Dictionary<TKey, TValue> (Dicionário / Mapa)

Armazena pares de chave e valor, permitindo buscas extremamente rápidas pela chave.
- **`Add(chave, valor)`**: Adiciona um par chave-valor (lança exceção se a chave já existir).
- **`Remove(chave)`**: Remove o elemento associado à chave especificada.
- **`ContainsKey(chave)`**: Verifica se a chave existe no dicionário.
- **`ContainsValue(valor)`**: Verifica se o valor existe no dicionário.
- **`TryGetValue(chave, out valor)`**: Tenta obter o valor de uma chave de forma segura, retornando um booleano.
- **`Clear()`**: Remove todas as chaves e valores.
- _Propriedades principais:_ `Keys` (retorna todas as chaves), `Values` (retorna todos os valores).

## 7. HashSet (Conjunto)

Armazena elementos únicos sem ordem garantida, otimizado para operações matemáticas de conjuntos.
- **`Add(item)`**: Adiciona o item se ele ainda não existir (retorna `true` se adicionado).
- **`Remove(item)`**: Remove o item especificado.
- **`Contains(item)`**: Verifica se o elemento está presente.
- **`UnionWith(colecao)`**: Une o HashSet com outra coleção (adiciona todos os elementos).
- **`IntersectWith(colecao)`**: Mantém apenas os elementos que estão presentes tanto no HashSet quanto na outra coleção.
- **`ExceptWith(colecao)`**: Remove do HashSet todos os elementos contidos na outra coleção.
- **`Clear()`**: Remove todos os elementos.

Estudo Anterior: [[14 - Tratamento de Exceções]]
Próximo Estudo: [[16 - Delegates, lambda e Generics]]

