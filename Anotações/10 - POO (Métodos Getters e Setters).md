No C#, os métodos **getters** e **setters** são usados para controlar o acesso e a modificação das propriedades de uma classe, garantindo o encapsulamento. Diferente de linguagens como Java, onde criamos métodos explícitos como `getPropriedade()` e `setPropriedade()`, o C# utiliza o conceito de **Propriedades (`Properties`)**.
### 1. Propriedades Completas (Full Properties)

Quando você precisa adicionar lógica de validação ou formatação ao ler ou alterar um valor, você declara uma propriedade associada a um campo privado (`backing field`).

```cs
public class Pessoa
{
    private string nome; // Campo privado

    public string Nome
    {
        get { return nome; }
        set 
        { 
            // Validação opcional no setter
            if (!string.IsNullOrEmpty(value))
            {
                nome = value; 
            }
        }
    }
}
```

- O parâmetro implícito `value` representa o valor que está sendo atribuído à propriedade.
### 2. Propriedades Automáticas (Auto-Implemented Properties)

Se você não precisa de nenhuma lógica customizada de validação, o C# permite simplificar a sintaxe usando propriedades automáticas. O compilador cria o campo privado oculto para você nos bastidores:

```cs
public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}
```

### 3. Controle de Acesso (Modificadores de Acesso)

Uma grande vantagem do C# é poder definir visibilidades diferentes para o `get` e o `set`. Por exemplo, você pode permitir que qualquer código leia a propriedade, mas apenas a própria classe possa alterá-la:

```cs
public class ContaBancaria
{
    // Apenas a classe pode modificar o saldo; o resto do sistema só pode ler
    public decimal Saldo { get; private set; } 

    public void Depositar(decimal valor)
    {
        if (valor > 0) Saldo += valor;
    }
}
```

### 4. Propriedades Somente Leitura (Read-Only)

Se você omitir o bloco `set`, a propriedade torna-se somente leitura após a inicialização:

```cs
public class Livro
{
    public string Titulo { get; } // Apenas get

    public Livro(string titulo)
    {
        Titulo = titulo; // Pode ser atribuído no construtor
    }
}
```

Estudo Anterior: [[09 - POO (Visibilidade de classes, atributos e métodos)]]
Próximo Estudo: [[11 - POO (Encapsulamento)]]
