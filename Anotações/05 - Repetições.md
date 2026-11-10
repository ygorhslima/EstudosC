As estruturas de repetição (ou laços) permitem executar um bloco de código várias vezes de forma automatizada, evitando a repetição manual de código e facilitando o processamento de coleções de dados ou validações condicionais.
### 1. `for`

O laço `for` é utilizado principalmente quando você **sabe exatamente quantas vezes** o bloco de código precisa ser executado. Ele reúne a inicialização, a condição de continuação e o incremento em uma única linha.

```cs
for (int i = 1; i <= 5; i++) {
    Console.WriteLine($"Contagem: {i}");
}
```

### 2. `while`

O laço `while` é utilizado quando a quantidade de repetições **não é conhecida antecipadamente** e depende de uma condição que é verificada **antes** de cada execução. Se a condição começar falsa, o bloco nunca é executado.

```cs
int tentativas = 3;
while (tentativas > 0) {
    Console.WriteLine($"Tentativas restantes: {tentativas}");
    tentativas--;
}
```

### 3. `do-while`

É muito parecido com o `while`, com uma diferença fundamental: a condição é verificada **no final** do bloco. Isso garante que o código dentro do `do` será executado **pelo menos uma vez**, mesmo que a condição seja falsa desde o início.

```cs
int senhaCorreta = 1234;
int senhaDigitada;

do {
    Console.WriteLine("Digite a senha:");
    senhaDigitada = int.Parse(Console.ReadLine());
} while (senhaDigitada != senhaCorreta);
```

### 4. `foreach`

O `foreach` é otimizado para **percorrer coleções** (como arrays, listas, etc.). Ele lê cada elemento da coleção sequencialmente de forma simples, sem precisar gerenciar contadores ou índices numéricos.

```cs
string[] frutas = { "Maçã", "Banana", "Laranja" };

foreach (string fruta in frutas) {
    Console.WriteLine($"Fruta: {fruta}");
}
```

Estudo anterior: [[04 - Condições]]
Próximo Estudo: [[06 - Arrays e Matrizes]]
