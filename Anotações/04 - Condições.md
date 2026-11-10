As estruturas condicionais em C# permitem que o programa tome decisões e altere o fluxo de execução com base em testes lógicos que resultam em valores booleanos (`true` ou `false`).
### 1. `if`, `else if` e `else`

São usados para testar condições. O programa avalia as expressões de cima para baixo e executa o bloco de código correspondente à **primeira condição verdadeira** que encontrar.

- **`if`**: Executa o bloco se a condição inicial for verdadeira.
- **`else if`**: Testa uma nova condição caso a anterior seja falsa.
- **`else`**: É o "fallback", executado se nenhuma das condições anteriores for atendida.

```cs
int nota = 75;

if (nota >= 90) {
    Console.WriteLine("Conceito A: Excelente!");
} else if (nota >= 70) {
    Console.WriteLine("Conceito B: Aprovado!");
} else {
    Console.WriteLine("Reprovado.");
}
```

### 2. `switch case`

O `switch` é uma alternativa mais limpa e legível ao uso excessivo de `if-else if` quando você precisa comparar **uma única variável ou expressão** contra múltiplos valores fixos e específicos.

```cs
int codigoCargo = 2;
switch (codigoCargo) {
    case 1:
        Console.WriteLine("Gerente");
        break; // O break encerra o bloco do case atual
    case 2:
        Console.WriteLine("Desenvolvedor");
        break;
    case 3:
        Console.WriteLine("Analista");
        break;
    default:
        Console.WriteLine("Cargo desconhecido"); // Executado se nenhum case corresponder
        break;
}
```
_(Nota: O C# também suporta o `switch expression`, uma sintaxe moderna e reduzida para retornar valores de forma direta baseada em padrões)._


Estudo Anterior: [[03 - Operadores Aritméticos, Logicos e Relacionais]]
Próximo estudo: [[05 - Repetições]]
