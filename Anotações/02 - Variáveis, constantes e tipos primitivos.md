Em C#, a tipagem é fortemente estática, o que significa que o tipo de cada variável e constante é conhecido em tempo de compilação.
### 1. Tipos Primitivos (Built-in Types)

O C# fornece um conjunto de tipos primitivos mapeados diretamente para o .NET. Eles são divididos principalmente entre tipos de valor (_Value Types_).

|   |   |   |   |   |
|---|---|---|---|---|
|**Tipo C#**|**Tipo .NET Equivalent**|**Tamanho**|**Intervalo / Precisão**|**Descrição**|
|`bool`|`System.Boolean`|1 byte|`true` ou `false`|Tipo lógico booleano.|
|`byte`|`System.Byte`|8 bits (1 byte)|$0$ a $255$|Inteiro sem sinal.|
|`sbyte`|`System.SByte`|8 bits (1 byte)|$-128$ a $127$|Inteiro com sinal.|
|`short`|`System.Int16`|16 bits (2 bytes)|$-32.768$ a $32.767$|Inteiro curto com sinal.|
|`ushort`|`System.UInt16`|16 bits (2 bytes)|$0$ a $65.535$|Inteiro curto sem sinal.|
|`int`|`System.Int32`|32 bits (4 bytes)|$-2.147.483.648$ a $2.147.483.647$|Inteiro padrão com sinal.|
|`uint`|`System.UInt32`|32 bits (4 bytes)|$0$ a $4.294.967.295$|Inteiro padrão sem sinal.|
|`long`|`System.Int64`|64 bits (8 bytes)|$-9.223.372.036.854.775.808$ a $9.223.372.036.854.775.807$|Inteiro longo com sinal.|
|`ulong`|`System.UInt64`|64 bits (8 bytes)|$0$ a $18.446.744.073.709.551.615$|Inteiro longo sem sinal.|
|`float`|`System.Single`|32 bits (4 bytes)|$\approx \pm 1,5 \times 10^{-45}$ a $\pm 3,4 \times 10^{38}$ (~7 dígitos)|Ponto flutuante de precisão simples. Exige o sufixo `f` ou `F`.|
|`double`|`System.Double`|64 bits (8 bytes)|$\approx \pm 5,0 \times 10^{-324}$ a $\pm 1,7 \times 10^{308}$ (~15-17 dígitos)|Ponto flutuante de precisão dupla (padrão para decimais).|
|`decimal`|`System.Decimal`|128 bits (16 bytes)|$\approx \pm 1,0 \times 10^{-28}$ a $\pm 7,9228 \times 10^{28}$ (28-29 dígitos)|Alta precisão financeira/monetária. Exige o sufixo `m` ou `M`.|
|`char`|`System.Char`|16 bits (2 bytes)|U+0000 a U+FFFF|Um único caractere Unicode. Usa aspas simples (ex: `'A'`).|

## Observações Importantes

1. **Sufixos Numéricos:**
    - `float`: `float f = 3.14f;`
    - `double`: `double d = 3.14;` (padrão)
    - `decimal`: `decimal m = 3.14m;`
    - `long`: `long l = 100L;`
    - `uint`: `uint u = 100U;`
2. **`string` e `object`:**
    - Embora `string` (`System.String`) e `object` (`System.Object`) sejam tipos nativos do C#, eles são **tipos de referência** (_Reference Types_), diferindo dos tipos primitivos de valor listados acima.
# Variáveis

Variáveis são posições de memória reservadas para armazenar dados que podem ser alterados durante a execução do programa.

- **Declaração explícita:** Você define o tipo seguido pelo nome.
    ```cs
    int idade = 25;
    string nome = "Maria";
    ```

- **Inferência de tipo (`var`):** O compilador descobre o tipo automaticamente com base no valor atribuído. Continua sendo fortemente tipado.
    ```cs
  var salario = 4500.50; // O compilador infere que é 'double'
    ```
### 3. Constantes

Constantes são valores fixos conhecidos em tempo de compilação e **não podem ser alterados** durante a execução. Utiliza-se a palavra-chave `const`.

```cs
const double Pi = 3.14159;
const int MaximoTentativas = 3;
```

_(Nota: O C# também possui o modificador `readonly`, que permite definir valores que só podem ser atribuídos no momento da declaração ou dentro de um construtor, diferindo do `const` que exige valor estático em tempo de compilação)._


Estudo anterior: [[01 - O que é a linguagem Csharp e como funciona]]
Próximo estudo: [[03 - Operadores Aritméticos, Logicos e Relacionais]]
