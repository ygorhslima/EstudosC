De acordo com a documentação oficial da Microsoft (Microsoft Learn), **delegates** e **expressões lambda** são conceitos profundamente interligados no C#: os delegates fornecem a infraestrutura do sistema de tipos, enquanto as lambdas oferecem a sintaxe concisa para criar o comportamento que é passado a esses delegates.
Aqui está a definição detalhada de cada um segundo a documentação:

### 1. Delegates (`Delegates`)

- **O que é:** Um delegate é um tipo que representa referências a métodos com uma assinatura específica (tipos de parâmetros e tipo de retorno). Pode ser entendido conceitualmente como um **ponteiro de função seguro quanto ao tipo** (_type-safe function pointer_)
- **Como funciona:** Quando você declara um delegate, você define um novo tipo que pode encapsular qualquer método que corresponda àquela assinatura.
- **Multicast:** Os delegates no C# suportam "multicast", o que significa que uma única instância de delegate pode conter referências a múltiplos métodos. Quando o delegate é invocado, todos os métodos da lista são executados em sequência. Eles também formam a base para o mecanismo de **Eventos** (`events`) do .NET.

- **Exemplo de declaração:**
    ```cs
    delegate int Transform(int value);
    ```
### 2. Expressões Lambda (`Lambda Expressions`)

- **O que é:** Uma expressão lambda é uma **função anônima** compacta, escrita sem um nome, que pode conter expressões ou instruções.
- **A sintaxe:** Utiliza o operador lambda `=>` (lido como "vai para"), separando a lista de parâmetros à esquerda do corpo da função à direita:
- **Expression Lambda** (corpo de expressão única):    
```cs
x => x * 2
```     

- **Statement Lambda** (corpo de bloco de código):
```cs
(x, y) => { 
	int sum = x + y; 
	return sum; 
}
```
        
- **A Relação:** **Delegates dão suporte a expressões lambda**. Sempre que um método espera um tipo delegate (ou um delegate genérico padrão como `Func` ou `Action`), você pode passar uma expressão lambda correspondente. O compilador do C# infere os tipos dos parâmetros e valida a segurança de tipos em tempo de compilação.

- **Tipo Natural:** A partir de versões mais recentes do C#, as lambdas possuem um "tipo natural" (_natural type_), o que significa que o compilador pode inferir automaticamente um delegate adequado (`Func` ou `Action`) mesmo se você não declarar explicitamente o tipo do delegate.

### Resumo da Relação

Enquanto o **delegate** define o "contrato" ou a assinatura estrutural de um método aceito (entradas e saídas), a **lambda** fornece o bloco de código funcional (o comportamento em si) que implementa esse contrato de forma fluida e inline.

# Generics

No **C#**, **Generics** (tipos genéricos) permitem que você defina classes, interfaces, métodos e delegates adiando a especificação de um ou mais tipos de dados até que o código seja instanciado ou chamado.

No seu contexto de estudos com C# e .NET, os generics são fundamentais para criar componentes eficientes, seguros e totalmente reutilizáveis.
### Como funcionam na prática

Em C#, os tipos genéricos utilizam colchetes angulares `<T>` (onde `T` significa _Type_ ou Tipo) como um espaço reservado.

Por exemplo, veja a diferença entre uma lista sem tipagem e uma lista genérica (`List<T>`):
- **Sem generics (estilo antigo/não seguro):** `ArrayList` armazena elementos como `object`. Qualquer tipo de dado entra, mas na hora de recuperar, você precisa fazer um _cast_ manual (`(int)lista[0]`). Se colocar o tipo errado, o programa quebra apenas ao rodar (**runtime error**).

- **Com generics (`List<T>`):** O compilador sabe exatamente o que está guardando. Em `List<int>`, tentar adicionar uma string gera um erro diretamente no editor (**compile-time error**), garantindo **type safety** e evitando conversões de tipos custosas (chamadas de _boxing_ e _unboxing_).
### Exemplo de Código: Criando uma classe genérica

Imagine que você quer criar um repositório simples para armazenar qualquer tipo de dado (seja um `Cliente`, um `Produto`, etc.):

```cs
public class Repositorio<T>
{
    private T _item;

    public void Salvar(T item)
    {
        _item = item;
    }

    public T Obter()
    {
        return _item;
    }
}
```

**Como você usaria isso:**

```cs
// Repositório especializado em strings
var repoTexto = new Repositorio<string>();
repoTexto.Salvar("Dados salvos com sucesso");
string texto = repoTexto.Obter(); // Não precisa de cast!

// Repositório especializado em um número inteiro
var repoNumero = new Repositorio<int>();
repoNumero.Salvar(42);
int numero = repoNumero.Obter();
```

### Principais Vantagens em Csharp

1. **Reutilização de Código:** Você escreve a lógica uma única vez para múltiplos tipos de dados.
2. **Segurança de Tipo (Type Safety):** O compilador impede que você passe o tipo incorreto, reduzindo drasticamente bugs em produção.
3. **Desempenho Superior:** Evita o _boxing_ e _unboxing_ (conversões entre tipos de valor e tipos de referência), o que economiza memória e processamento, especialmente em coleções.

Estudo Anterior: [[15 - Coleções (Estrutura de Dados)]]
Próximo Estudo: [[17 - LINQ]]
