A Programação Orientada a Objetos (POO) em C# é um dos pilares fundamentais da linguagem, projetada desde a sua concepção para ser fortemente orientada a objetos. Em C#, quase tudo é baseado em classes e objetos, o que permite estruturar o código de forma modular, reutilizável e de fácil manutenção.

# características do POO

 Representam os principais **objetivos e benefícios da Programação Orientada a Objetos (POO)** na engenharia de software — conjunto frequentemente associado ao acrônimo **COMERN**. Elas descrevem como a modelagem baseada em objetos impacta a qualidade, o ciclo de vida e a compreensão do código:
 
- **Confiável:** Graças ao **encapsulamento**, os dados e o comportamento ficam protegidos dentro dos objetos. O isolamento entre as partes garante que a alteração ou correção em um componente específico não afete acidentalmente o restante do sistema, gerando um software mais seguro e previsível.

- **Oportuno:** Refere-se à agilidade e à capacidade de **desenvolvimento em paralelo**. Como o sistema é dividido em classes e módulos independentes, diferentes desenvolvedores podem trabalhar em partes distintas do projeto simultaneamente, acelerando as entregas.

- **Manutenível:** Facilita a realização de manutenções, atualizações e correções de bugs. Como a responsabilidade está bem distribuída entre os objetos, saber onde agir quando algo precisa de conserto se torna muito mais direto, reduzindo custos a longo prazo.

- **Extensível:** O software não é estático; ele foi feito para crescer. Com o uso de **herança e polimorfismo**, é possível adicionar novas funcionalidades, comportamentos ou adaptar o sistema para novos cenários sem precisar reescrever o código que já está pronto e funcionando.

- **Reutilizável:** Permite o reaproveitamento de código já testado e validado. Classes e métodos criados para um problema específico podem ser reutilizados em outros módulos ou novos projetos, evitando a duplicação de esforço.  

- **Natural:** A POO busca aproximar a lógica do software da **realidade do mundo físico**. Os problemas são mapeados em "objetos" que possuem características (atributos) e ações (métodos), tornando a modelagem e a leitura do código mais intuitivas para a mente humana.
### 1. Classes e Objetos

- **Classe:** É o molde ou a planta baixa que define os atributos (dados/variáveis) e os comportamentos (métodos/funções) que os objetos daquele tipo terão.
	- **Atributos**: que coisas o objeto tem?
	- **Métodos**: que coisas o objeto faz?
- **Objeto:** É a instância concreta de uma classe. Quando você cria um objeto, você aloca memória para ele com base no modelo da classe.

```cs
// Exemplo de Classe
public class Carro 
{
    // Atributos (Propriedades)
    public string Modelo { get; set; }
    public int Ano { get; set; }

    // Método (Comportamento)
    public void Acelerar() 
    {
        Console.WriteLine($"O {Modelo} está acelerando!");
    }
}

// Utilização (Criando um Objeto)
Carro meuCarro = new Carro();
meuCarro.Modelo = "Sedan";
meuCarro.Ano = 2026;
meuCarro.Acelerar();
```

Estudo Anterior: [[07 - Métodos]]
Próximo Estudo [[09 - POO (Visibilidade de classes, atributos e métodos)]]