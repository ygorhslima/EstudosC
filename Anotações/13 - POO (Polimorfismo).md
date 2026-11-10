O **polimorfismo** (que significa "muitas formas") é o terceiro grande pilar da Programação Orientada a Objetos. Ele permite que objetos de tipos diferentes sejam tratados através de uma mesma interface ou classe base, mas executando comportamentos específicos de acordo com o seu tipo real em tempo de execução.

No C#, o polimorfismo anda de mãos dadas com a herança e as interfaces. Ele se divide basicamente em dois tipos: **Polimorfismo de Sobreposição e **Polimorfismo de Sobrecarga**

### 1. Polimorfismo de Sobreposição

É o cenário mais clássico: você tem uma referência do tipo pai (ou de uma interface), mas o objeto apontado é de um tipo filho. Quando você chama um método, o C# executa a versão específica daquele objeto filho, e não a do pai.

Para que isso funcione, usamos duas palavras-chave que vimos brevemente na herança:
- **`virtual`**: Na classe base, avisa que o método pode ser modificado.
- **`override`**: Na classe derivada, substitui o comportamento original.

```cs
public class Funcionario
{
    // Método virtual que pode ser sobrescrito
    public virtual void Trabalhar()
    {
        Console.WriteLine("O funcionário está realizando tarefas gerais.");
    }
}

public class Desenvolvedor : Funcionario
{
    public override void Trabalhar()
    {
        Console.WriteLine("O desenvolvedor está escrevendo código C#.");
    }
}

public class Designer : Funcionario
{
    public override void Trabalhar()
    {
        Console.WriteLine("O designer está criando layouts no Figma.");
    }
}
```

#### Como o polimorfismo brilha na prática:

Você pode tratar diferentes objetos de forma genérica numa lista:
```cs
List<Funcionario> equipe = new List<Funcionario>
{
    new Desenvolvedor(),
    new Designer(),
    new Funcionario()
};

foreach (var funcionario in equipe)
{
    // O C# descobre em tempo de execução qual método chamar!
    funcionario.Trabalhar();
}
```
**Saída no console:**
```
O desenvolvedor está escrevendo código C#.
O designer está criando layouts no Figma.
O funcionário está realizando tarefas gerais.
```

### 2. Polimorfismo com Interfaces

O polimorfismo também funciona perfeitamente com interfaces. Como vimos no exemplo de encapsulamento/interfaces, diferentes classes podem implementar a mesma interface de maneiras distintas.

```cs
public interface INotificacao
{
    void Enviar(string mensagem);
}

public class EmailNotificacao : INotificacao
{
    public void Enviar(string mensagem) => Console.WriteLine($"Enviando E-mail: {mensagem}");
}

public class SmsNotificacao : INotificacao
{
    public void Enviar(string mensagem) => Console.WriteLine($"Enviando SMS: {mensagem}");
}
```

Quem consome a interface (`INotificacao`) não precisa saber se o envio é por E-mail ou SMS; ele apenas chama o método `.Enviar()` polimorficamente.
### 3. Polimorfismo em Tempo de Compilação (Sobrecarga / Overload)

Este tipo ocorre quando você tem vários métodos com o **mesmo nome**, mas com **assinaturas diferentes** (parâmetros com tipos ou quantidades diferentes) dentro da mesma classe. O compilador decide qual método chamar com base nos argumentos passados.

```cs
public class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    // Mesmo nome, mas recebe 3 inteiros (sobrecarga)
    public int Somar(int a, int b, int c)
    {
        return a + b + c;
    }

    // Mesmo nome, mas recebe números decimais
    public decimal Somar(decimal a, decimal b)
    {
        return a + b;
    }
}
```

### Por que o polimorfismo é poderoso?

- **Extensibilidade**: Você pode adicionar novas classes filhas (ex: `Gerente : Funcionario`) sem precisar reescrever o código que consome a classe pai.
- **Desacoplamento**: Reduz a necessidade de códigos cheios de estruturas `if/else` ou `switch` para verificar o tipo de um objeto.


Estudo Anterior: [[12 - POO (Herança)]]
Próximo Estudo: [[14 - Tratamento de Exceções]]
