No C#, **métodos** são blocos de código que contêm uma série de instruções para realizar uma tarefa específica. Eles são equivalentes a **funções ou procedimentos** em outras linguagens e servem principalmente para organizar o código, evitar repetição (princípio DRY - _Don't Repeat Yourself_) e facilitar a manutenção.

### Estrutura Básica de um Método

Um método típico em C# possui a seguinte assinatura:

```cs
[ModificadorAcesso] [TipoRetorno] NomeDoMetodo([Parametros])
{
    // Corpo do método: instruções a serem executadas
    return valorRetorno; // Opcional se o tipo for void
}
```

- **Modificador de Acesso**: Define quem pode chamar o método (ex: `public`, `private`, `protected`).
- **Tipo de Retorno**: O tipo de dado que o método devolve após a execução (ex: `int`, `string`, `bool`). Se não retornar nada, usa-se a palavra-chave `void`.
- **Nome do Método**: O identificador usado para chamá-lo (por convenção, em C# usa-se _PascalCase_, como `CalcularMedia`).    
- **Parâmetros**: Os dados de entrada que o método recebe entre parênteses (opcionais).
### Exemplo Prático

```cs
class Program
{
	public static void Main(string[] args){
		int res = Somar(10,10)
		Console.WriteLine(res);
	}
    // Método que recebe dois números inteiros e retorna a soma deles
    static int Somar(int a, int b)
    {
        int resultado = a + b;
        return resultado;
    }
}
```

# passagens por valor e por referência

No C#, a forma como os argumentos são passados para os métodos determina se estamos alterando a variável original ou apenas uma cópia dela. O comportamento padrão da linguagem é a **passagem por valor**, mas você pode explicitamente usar a **passagem por referência** quando necessário.
### 1. Passagem por Valor (Padrão)

Na passagem por valor, o C# cria uma **cópia** do dado e a envia para o método. Qualquer alteração feita no parâmetro dentro do método **não afeta** a variável original fora dele.


- **Para Tipos de Valor (`int`, `bool`, `double`, `struct`):** O valor real é copiado.
- **Para Tipos de Referência (`class`, `string`, arrays):** O que é copiado é a _cópia da referência_ (o endereço de memória). Isso significa que se você alterar uma propriedade do objeto dentro do método, o original reflete a mudança. Porém, se você substituir o objeto inteiro por um novo (`objeto = novo Objeto`), a variável original continuará apontando para o objeto antigo.

```cs
void Modificar(int numero, int[] meuArray)
{
    numero = 10;        // Altera apenas a cópia local
    meuArray[0] = 99;   // Altera o conteúdo do array original (pois o endereço é o mesmo)
}

int x = 5;
int[] numeros = { 1, 2, 3 };

Modificar(x, numeros);
// x continua sendo 5
// numeros[0] agora é 99
```

### 2. Passagem por Referência (`ref`, `out`, `in`)

Na passagem por referência, o método não recebe uma cópia, mas sim o **endereço de memória real** da variável original. Qualquer alteração feita no parâmetro reflete imediatamente na variável de fora.

Para isso, usamos modificadores específicos:
- **`ref`**: Indica que a variável é passada por referência. **Importante:** a variável precisa ser inicializada antes de ser passada para o método.
- **`out`**: Similar ao `ref`, mas usado quando o método tem a responsabilidade de _atribuir_ um valor à variável (muito usado para retornar múltiplos valores). A variável não precisa estar inicializada antes.
- **`in`**: Passa por referência, mas torna o parâmetro **somente leitura** (ótimo para otimizar a performance com structs grandes, impedindo que sejam copiadas na memória).

#### Exemplo com `ref`:

```cs
void DobrarValor(ref int numero)
{
    numero = numero * 2; // Modifica diretamente a variável original
}

int valor = 10;
DobrarValor(ref valor);
// Agora 'valor' vale 20
```

### Resumo Prático

| **Tipo**                   | **Cópia criada?**                    | **Afeta o original?**                                                    | **Palavra-chave** |
| -------------------------- | ------------------------------------ | ------------------------------------------------------------------------ | ----------------- |
| **Por Valor**              | Sim (cópia do dado ou da referência) | Apenas se for tipo de referência e você modificar propriedades internas. | Nenhuma (padrão)  |
| **Por Referência (`ref`)** | Não                                  | **Sim** (modifica o original diretamente)                                | `ref`             |
| **Por Referência (`out`)** | Não                                  | **Sim** (usado para saída de dados)                                      | `out`             |
Estudo Anterior: [[06 - Arrays e Matrizes]]
Proximo Estudo: [[08 - POO (Classe e Objeto)]]
