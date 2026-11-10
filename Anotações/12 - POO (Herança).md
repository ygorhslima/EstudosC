A **herança** é outro pilar fundamental da Programação Orientada a Objetos (POO). Ela permite que você crie novas classes com base em classes já existentes, reaproveitando código, estruturando hierarquias e estabelecendo uma relação do tipo _"é um"_ (_is-a_).
Quando uma classe herda de outra, ela ganha automaticamente todos os campos, propriedades e métodos públicos e protegidos da classe pai, podendo reutilizá-los, estendê-los ou modificá-los.
### 1. Sintaxe Básica da Herança

Em C#, usamos os dois-pontos (`:`) para indicar que uma classe está herdando de outra. A classe que é herdada é chamada de **classe base** (ou pai), e a nova classe é chamada de **classe derivada** (ou filha)

```cs
// Classe Base (Pai)
public class Animal
{
    public string Nome { get; set; }

    public void Comer()
    {
        Console.WriteLine($"{Nome} está comendo.");
    }
}

// Classe Derivada (Filha) herda de Animal
public class Cachorro : Animal
{
    public void Latir()
    {
        Console.WriteLine($"{Nome} está latindo: Au Au!");
    }
}
```

### Utilizando a Herança na prática:

```cs
Cachorro meuCachorro = new Cachorro();
meuCachorro.Nome = "Rex"; // Herdado de Animal
meuCachorro.Comer();      // Método herdado de Animal
meuCachorro.Latir();      // Método próprio da classe Cachorro
```

### 2. Modificador `protected` (Herança vs Encapsulamento)

Lembra do encapsulamento? O modificador `protected` entra exatamente aqui. Ele funciona como o `private` (esconde o dado do mundo externo), mas permite que **as classes filhas tenham acesso**.

```cs
public class ContaBancaria
{
    protected decimal saldo; // Filhas podem acessar, o resto do mundo não
}

public class ContaEspecial : ContaBancaria
{
    public void UsarChequeEspecial()
    {
        saldo += 500; // Permitido porque 'saldo' é protected
    }
}
```

### 3. Polimorfismo: `virtual` e `override`

Por padrão, métodos nas classes base podem ser chamados diretamente, mas e se a classe filha quiser **mudar o comportamento** de um método herdado? É aí que entram as palavras-chave `virtual` e `override`:

- **`virtual`**: Permite que um método da classe base seja sobrescrito.
- **`override`**: Indica que a classe filha está reescrevendo o comportamento daquele método.

```cs
public class Animal
{
    public virtual void FazerSom()
    {
        Console.WriteLine("O animal faz um som.");
    }
}

public class Gato : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("O gato mia: Miau!");
    }
}
```

### 4. Regras Importantes do C# no contexto de Herança

- **Herança Simples**: O C# **não** suporta herança múltipla de classes (uma classe não pode herdar de duas classes ao mesmo tempo, como `class C : A, B` é proibido). No entanto, uma classe pode implementar **múltiplas interfaces**.
- **Construtores não são herdados**: Os construtores da classe base não são herdados automaticamente. Se a classe pai exige parâmetros no construtor, a classe filha precisa repassá-los usando a palavra `base(...)`.

Estudo Anterior: [[11 - POO (Encapsulamento)]]
Próximo Estudo: [[13 - POO (Polimorfismo)]]
