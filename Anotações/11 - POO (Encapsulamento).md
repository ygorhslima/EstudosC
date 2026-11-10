O **encapsulamento** é um dos pilares da programação orientada a objetos (POO). Ele consiste em esconder o estado interno e os detalhes de funcionamento de um objeto, permitindo o acesso a eles apenas por meio de interfaces controladas, como propriedades e métodos públicos.

No C#, o encapsulamento é implementado principalmente por meio de duas ferramentas:

1. **Modificadores de Acesso**: Definem o escopo de visibilidade de classes, métodos e variáveis.
2. **Propriedades (Getters e Setters)**: Controlam como os dados são lidos e modificados, permitindo regras de validação.
### Exemplo Prático

No exemplo abaixo, o saldo da conta não pode ser alterado de forma arbitrária de fora da classe. Ele é protegido e só pode ser modificado por regras de negócio específicas (métodos de depósito e saque) ou lido com segurança.

```cs
public class ContaBancaria
{
    // Campo privado: o dado está encapsulado e seguro contra modificações diretas
    private decimal saldo;

    // Propriedade somente leitura para expor o saldo de forma segura
    public decimal Saldo
    {
        get { return saldo; }
    }

    // Método que encapsula a lógica e validação para adicionar dinheiro
    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            saldo += valor;
        }
    }

    // Método que encapsula a regra de retirada
    public bool Sacar(decimal valor)
    {
        if (valor > 0 && saldo >= valor)
        {
            saldo -= valor;
            return true;
        }
        return false;
    }
}
```

### Por que o encapsulamento é importante?

- **Proteção de dados**: Impede que o estado do objeto seja corrompido por valores inválidos vindos de fora.
- **Manutenibilidade**: Você pode alterar a lógica interna de uma classe (por exemplo, mudar a forma como os dados são salvos) sem afetar o código externo que a utiliza, desde que a interface pública permaneça a mesma.
# Recurso `interface` do C# (Contratos)

No C#, `interface` é uma palavra-chave usada para definir um **contrato**. Uma interface diz _quais_ propriedades e métodos uma classe deve ter, mas não _como_ eles funcionam por dentro.
As interfaces podem exigir que classes implementem determinados **getters e setters**:

```cs
// Definindo um contrato (interface)
public interface IContaBancaria
{
    // A interface exige que quem a implementar tenha uma propriedade com get (e opcionalmente set)
    decimal Saldo { get; }

    void Depositar(decimal valor);
    bool Sacar(decimal valor);
}

// A classe cumpre o contrato
public class ContaCorrente : IContaBancaria
{
    private decimal saldo;

    public decimal Saldo
    {
        get { return saldo; }
    }

    public void Depositar(decimal valor)
    {
        if (valor > 0) saldo += valor;
    }

    public bool Sacar(decimal valor)
    {
        if (valor > 0 && saldo >= valor)
        {
            saldo -= valor;
            return true;
        }
        return false;
    }
}
```

### Por que usar interfaces junto com o encapsulamento?

- **Desacoplamento**: Quem usa a conta bancária interage apenas com `IContaBancaria`, sem precisar saber se a classe se chama `ContaCorrente`, `ContaPoupanca` ou como o saldo é calculado internamente.
- **Padronização**: Garante que diferentes classes sigam rigorosamente o mesmo padrão de propriedades e métodos encapsulados.


Estudo Anterior: [[10 - POO (Métodos Getters e Setters)]]
Próximo Estudo: [[12 - POO (Herança)]]
