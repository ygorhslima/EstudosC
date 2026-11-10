O **LINQ** (que significa _Language Integrated Query_, ou Consulta Integrada à Linguagem) é um recurso poderoso do ecossistema .NET que traz a capacidade de consultar e manipular dados diretamente na linguagem C# (ou VB.NET) de forma padronizada, legível e segura em tempo de compilação.

Em vez de usar loops tradicionais (`for`, `foreach`) e declarações condicionais `if` para filtrar ou ordenar coleções, o LINQ permite que você escreva consultas semelhantes ao SQL diretamente no seu código.
### Principais Vantagens
- **Padronização:** Você usa a mesma sintaxe básica para consultar diferentes fontes de dados (coleções em memória como Listas e Arrays, bancos de dados via Entity Framework, arquivos XML, JSON, etc.).
- **Tipagem Forte (Strong Typing):** O compilador verifica seus erros de digitação e tipos de dados antes de rodar o programa (IntelliSense completo).
- **Legibilidade:** O código fica muito mais limpo, declarativo e curto.
### As Duas Formas de Usar o LINQ

O LINQ pode ser escrito de duas maneiras principais:
#### 1. Sintaxe de Métodos (Method Syntax / Fluent API)

Utiliza métodos de extensão fornecidos pelo namespace `System.Linq` em conjunto com expressões Lambda. É a forma mais utilizada no dia a dia.

```cs
using System;
using System.Collections.Generic;
using System.Linq;

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Filtrar números pares usando LINQ Method Syntax
var numerosPares = numeros.Where(n => n % 2 == 0).ToList();
```

#### 2. Sintaxe de Consulta (Query Syntax)

Possui uma estrutura que lembra bastante o SQL, sendo ideal para consultas complexas envolvendo junções (_joins_).

```cs
using System;
using System.Collections.Generic;
using System.Linq;

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Filtrar números pares usando LINQ Query Syntax
var numerosPares = from n in numeros
                   where n % 2 == 0
                   select n;
```


# Métodos do LINQ

O LINQ possui dezenas de métodos de extensão (pertencentes aos namespaces `System.Linq.Enumerable` e `System.Linq.Queryable`) que facilitam a manipulação de dados. Eles são divididos por categorias de acordo com o objetivo da operação:
### 1. Filtragem (Filtering)

- **`Where`**: Filtra elementos com base em um predicado (condição booleana).
- **`OfType`**: Filtra os elementos de uma coleção com base em um tipo específico
### 2. Projeção (Projection)

- **`Select`**: Transforma cada elemento de uma sequência em uma nova forma ou objeto.
- **`SelectMany`**: Projeta cada elemento em uma sequência e achata os resultados em uma única coleção.
### 3. Ordenação (Ordering)

- **`OrderBy` / `OrderByDescending`**: Ordena os elementos em ordem crescente ou decrescente.
- **`ThenBy` / `ThenByDescending`**: Realiza uma ordenação secundária após um `OrderBy`.
- **`Reverse`**: Inverte a ordem dos elementos de uma sequência.
### 4. Agregação (Aggregation)

- **`Count`**: Retorna o número de elementos.
- **`Sum`**: Calcula a soma dos valores numéricos.
- **`Average`**: Calcula a média de valores numéricos.
- **`Min` / `Max`**: Encontra o menor ou maior valor.
- **`Aggregate`**: Aplica uma função acumuladora personalizada em uma sequência.
### 5. Operações com Elementos (Element Operations)

- **`First` / `FirstOrDefault`**: Retorna o primeiro elemento (ou o primeiro que satisfaça uma condição); `OrDefault` retorna o valor padrão se não encontrar nada (evitando exceções).
- **`Last` / `LastOrDefault`**: Retorna o último elemento.
- **`Single` / `SingleOrDefault`**: Retorna um único elemento específico (lança exceção se houver mais de um).
- **`ElementAt`**: Retorna o elemento em um índice específico.
### 6. Quantificadores (Quantifiers)

- **`Any`**: Verifica se _qualquer_ elemento atende a uma condição (ou se a coleção não está vazia).
- **`All`**: Verifica se _todos_ os elementos atendem a uma condição.
- **`Contains`**: Verifica se a sequência contém um elemento específico.
### 7. Agrupamento e Particionamento

- **`GroupBy`**: Agrupa elementos com base em uma chave comum.
- **`Take`**: Retorna um número específico de elementos do início.
- **`Skip`**: Pula um número específico de elementos.
### 8. Conversão (Conversion)

- **`ToList`**: Converte a sequência em uma `List<T>`.
- **`ToArray`**: Converte a sequência em um array (`T[]`).
- **`ToDictionary`**: Converte a sequência em um dicionário chave-valor (`Dictionary<TKey, TValue>`).

Estudo Anterior: [[16 - Delegates, lambda e Generics]]
Próximo Estudo: [[18 - Programação Assíncrona I (Async, await)]]
