O tratamento de exceções em C# é realizado através da estrutura **`try-catch-finally`**, auxiliada pela palavra-chave **`throw`**. Esse mecanismo permite que você isole códigos que possam falhar, capture o erro de forma controlada e execute ações de limpeza, evitando que a aplicação feche abruptamente.

Aqui está um resumo de como cada componente funciona na prática:
- **`try`**: Bloco onde você coloca o código "arriscado", ou seja, operações que podem lançar uma exceção (como leitura de arquivos, conexões com banco de dados ou conversão de tipos).
- **`catch`**: Bloco responsável por capturar a exceção caso ela ocorra no `try`. Você pode ter múltiplos blocos `catch` para tratar diferentes tipos de erros de forma específica (por exemplo, `DivideByZeroException` vs `FormatException`).
- **`finally`**: Bloco opcional que é **sempre executado**, independentemente de ter ocorrido uma exceção ou não. É ideal para liberar recursos, como fechar conexões ou arquivos abertos.
- **`throw`**: Utilizado para lançar manualmente uma exceção quando uma regra de negócio é violada ou para repassar um erro capturado
### Exemplo Prático

```cs
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Digite um número para dividir 10: ");
            string entrada = Console.ReadLine();
            
            // Pode lançar FormatException se a entrada não for número
            int numero = int.Parse(entrada); 
            
            // Pode lançar DivideByZeroException se o número for 0
            int resultado = 10 / numero; 

            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Erro: Não é permitido dividir por zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Você deve digitar um número válido.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Bloco finally executado. Limpeza de recursos realizada.");
        }
    }
}
```

### Boas Práticas
- **Seja específico:** Evite capturar a exceção genérica (`Exception`) a menos que seja o último recurso. Capture exceções específicas (`SqlException`, `FileNotFoundException`, etc.) para tratar cada cenário corretamente.
- **Não use exceções para fluxo normal:** O tratamento de exceções é custoso para a performance da aplicação. Validações simples de dados devem ser feitas com condicionais (`if/else`), reservando o `try-catch` para situações verdadeiramente excepcionais.

# Objetos de exceções e Classes de exceções

No C# e no ecossistema .NET, todas as exceções derivam da classe base **`System.Exception`**. O mecanismo de tratamento de erros é estruturado em uma hierarquia rica que ajuda a identificar exatamente qual tipo de falha ocorreu durante a execução do programa.
## 1. A Hierarquia e a Classe Base (`System.Exception`)

A classe `System.Exception` fornece as propriedades fundamentais compartilhadas por todos os objetos de exceção. As propriedades mais importantes que você encontrará ao inspecionar uma exceção são:
- **`Message`**: Uma string descritiva que explica o motivo da exceção.
- **`StackTrace`**: Uma string contendo a pilha de chamadas de métodos (stack trace) que levaram ao ponto onde o erro ocorreu, essencial para depuração.    
- **`InnerException`**: Usada quando uma exceção é capturada e uma nova é lançada em seu lugar, permitindo manter o histórico do erro original (encadeamento de exceções).
- **`Source`**: O nome do aplicativo ou do assembly que causou o erro.
- **`TargetSite`**: O método exato que lançou a exceção.
## 2. Principais Classes de Exceção do Runtime (BCL)

As exceções mais comuns no dia a dia do desenvolvimento C# pertencem ao namespace `System` (ou namespaces filhos como `System.IO`) e representam erros comuns de lógica, dados ou ambiente.
### Exceções de Argumentos e Valores

- **`ArgumentException`**: Lançada quando um argumento inválido é passado para um método.
- **`ArgumentNullException`**: Uma subclasse específica e muito comum lançada quando um argumento obrigatório é `null` (ex: `if (param == null) throw new ArgumentNullException(nameof(param));`).
- **`ArgumentOutOfRangeException`**: Ocorre quando o valor de um argumento está fora do intervalo permitido (ex: passar um número negativo para um tamanho de array).
### Exceções de Referência e Estado

- **`NullReferenceException`**: Lançada quando você tenta acessar um membro (como propriedade ou método) de uma referência de objeto que aponta para `null`. (Dica: O C# moderno com _Nullable Reference Types_ ajuda a prevenir isso em tempo de compilação).
- **`InvalidOperationException`**: Lançada quando o estado de um objeto não permite que uma operação específica seja executada no momento (ex: chamar `Read()` em um leitor de dados que já foi fechado).
### Exceções de Conversão e Formato

- **`FormatException`**: Ocorre quando o formato de uma string não está em conformidade com o exigido por um método de conversão (ex: `int.Parse("abc")`).
- **`OverflowException`**: Lançada quando uma operação aritmética, de coerção ou de conversão resulta em um estouro (overflow), ultrapassando os limites do tipo de dado (ex: atribuir um número maior que o suportado por `int`).
### Exceções de Coleções e Índices

- **`IndexOutOfRangeException`**: Ocorre quando você tenta acessar um elemento de um array ou coleção usando um índice inválido (negativo ou maior/igual ao tamanho da estrutura).
- **`KeyNotFoundException`**: Lançada quando a chave especificada para acessar um elemento em uma coleção baseada em chave (como `Dictionary<TKey, TValue>`) não existe.
### Exceções Matemáticas

- **`DivideByZeroException`**: Lançada quando ocorre uma tentativa de divisão por 0
### Exceções de Entrada/Saída (I/O)

- **`FileNotFoundException` / `DirectoryNotFoundException`**: Lançadas quando um arquivo ou diretório físico não pode ser encontrado no disco.
- **`IOException`**: A classe base para erros gerais de I/O (como falhas de leitura/escrita em disco ou rede).
## 3. Criando Exceções Personalizadas (Custom Exceptions)

Quando as exceções padrão do .NET não descrevem com precisão o domínio do seu negócio, você pode criar suas próprias classes de exceção herdando de `System.Exception` (ou de classes mais específicas como `InvalidOperationException`).

```cs
public class SaldoInsuficienteException : Exception
{
    public decimal SaldoAtual { get; }
    public decimal ValorRequerido { get; }

    public SaldoInsuficienteException(decimal saldoAtual, decimal valorRequerido) 
        : base($"Saldo insuficiente. Atual: {saldoAtual:C}, Requerido: {valorRequerido:C}")
    {
        SaldoAtual = saldoAtual;
        ValorRequerido = valorRequerido;
    }
}
```

Estudo Anterior: [[13 - POO (Polimorfismo)]]
Próximo Estudo: [[15 - Coleções (Estrutura de Dados)]]
