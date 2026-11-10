Um **Array** (ou matriz) em C# é uma estrutura de dados que permite armazenar uma **coleção de elementos de um mesmo tipo** em posições de memória contíguas e sequenciais.
Diferente de uma variável comum que guarda apenas um valor, o array funciona como uma "fileira de caixas numeradas", onde cada item possui um **índice** numérico para identificação.
### Características Principais

- **Tamanho Fixo:** Uma vez que o array é criado, o seu tamanho (número de elementos) **não pode ser alterado**. Se precisar de uma lista que cresce ou diminui dinamicamente, utiliza-se o `List<T>` em C#.
- **Indexação Baseada em Zero (`0`):** O primeiro elemento de um array sempre começa no índice `0`, o segundo no índice `1`, e assim por diante até o tamanho máximo menos um (`tamanho - 1`).
- **Tipagem Estrita:** Todos os elementos dentro do array devem ser obrigatoriamente do mesmo tipo declarado (ex: um array de `int` só guarda inteiros).
### Exemplos Práticos de Uso

#### 1. Declaração e Inicialização Direta

Você pode declarar um array informando seus valores iniciais diretamente:

```cs
// Array de strings com 4 elementos
string[] diasDaSemana = { "Segunda", "Terça", "Quarta", "Quinta", "Sexta" };

// Acessando um elemento pelo índice
Console.WriteLine(diasDaSemana[0]); // Saída: Segunda
Console.WriteLine(diasDaSemana[2]); // Saída: Quarta
```

#### 2. Declaração Definindo o Tamanho

Você também pode criar um array informando primeiro o seu tamanho fixo e atribuir os valores depois:

```cs
// Cria um array de inteiros que comporta exatamente 3 números
int[] numeros = new int[3];

numeros[0] = 10;
numeros[1] = 20;
numeros[2] = 30;
```

#### 3. Percorrendo um Array com Loops

É muito comum utilizar estruturas de repetição (como o `for` ou o `foreach`) para percorrer todos os itens de um array:

```cs
string[] frutas = { "Maçã", "Banana", "Laranja" };

// Usando foreach para ler cada item
foreach (string fruta in frutas) {
    Console.WriteLine($"Fruta: {fruta}");
}
```

# Matrizes
No contexto da programação e do C#, uma **matriz** (também chamada de array multidimensional) é uma evolução do array tradicional. Enquanto um array comum armazena os dados em uma única linha (sequencial), a matriz organiza os dados em **linhas e colunas**, formando uma grade ou tabela.
### Tipos de Matrizes no C#

1. **Matrizes Retangulares (Multidimensionais):** Possuem dimensões fixas e uniformes. O formato mais comum é o bidimensional (`[ , ]`), que funciona como uma tabela com linhas e colunas.
2. **Matrizes Denteadas (_Jagged Arrays_):** São "arrays de arrays", onde cada linha da matriz pode ter um tamanho diferente (por exemplo, a primeira linha tem 3 elementos e a segunda tem 5).
### Exemplos Práticos

#### 1. Criando e Acessando uma Matriz 2D (Retangular)

Para declarar uma matriz bidimensional em C#, utilizamos uma vírgula dentro dos colchetes (`[ , ]`):

```cs
// Declara e inicializa uma matriz de 2 linhas e 3 colunas
int[,] matriz = {
    { 1, 2, 3 }, // Linha 0
    { 4, 5, 6 }  // Linha 1
};

// Acessando um valor específico (Linha 0, Coluna 1)
Console.WriteLine(matriz[0, 1]); // Saída: 2

// Alterando um valor
matriz[1, 2] = 99; // O número 6 na linha 1, coluna 2 vira 99
```

#### 2. Percorrendo uma Matriz com Loops Aninhados

Como a matriz possui dimensões de linha e coluna, usamos normalmente dois laços `for` aninhados para percorrê-la inteira:
```cs
int[,] notasAlunos = {
    { 8, 7, 9 },
    { 6, 5, 7 }
};

// Obtendo as dimensões da matriz
int totalLinhas = notasAlunos.GetLength(0);
int totalColunas = notasAlunos.GetLength(1);

for (int i = 0; i < totalLinhas; i++) {
    for (int j = 0; j < totalColunas; j++) {
        Console.Write($"{notasAlunos[i, j]} ");
    }
    Console.WriteLine(); // Quebra a linha ao terminar as colunas de cada linha
}
```

# Métodos estáticos de Arrays no Csharp

- **`Array.Sort(array)`**: Ordena os elementos de um array unidimensional em ordem crescente.
- **`Array.Reverse(array)`**: Inverte a ordem dos elementos em todo o array.    
- **`Array.IndexOf(array, valor)`**: Pesquisa o valor especificado e retorna o índice da primeira ocorrência.
- **`Array.BinarySearch(array, valor)`**: Realiza uma busca binária em um array ordenado para localizar um elemento de forma rápida.
- **`Array.Copy(origem, destino, tamanho)`**: Copia um bloco de elementos de um array para outro.
- **`Array.Clear(array, índice, comprimento)`**: Define uma faixa de elementos no array como seus valores padrão (como `0` para números ou `null` para objetos).
- **`Array.Find(array, predicado)`**: Retorna o primeiro elemento que corresponde às condições definidas em uma função lambda.
- **`Array.Exists(array, predicado)`**: Retorna um booleano indicando se existe algum elemento que atende à condição.
- **`Array.Resize(ref array, novoTamanho)`**: Altera o tamanho de um array (criando internamente uma nova matriz redimensionada e copiando os elementos antigos).
### Propriedades Importantes

- **`Length`**: Retorna o número total de elementos do array.
- **`Rank`**: Retorna o número de dimensões do array (por exemplo, `1` para unidimensional).

Estudo Anterior: [[05 - Repetições]]
Próximo Estudo: [[07 - Métodos]]
