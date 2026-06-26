using System;

namespace Aula12;

public class Mamifero(
    float peso, 
    int idade, 
    int membros, 
    string corPelo
) : Animal(peso, idade, membros)
{
    private string CorPelo = corPelo;

    public string GetCorPelo()
    {
        return this.CorPelo;
    }

    public void SetCorPelo(string CorPelo)
    {
        this.CorPelo = CorPelo;
    }

    public override void Alimentar()
    {
        Console.WriteLine("Mamando");
    }

    public override void EmitirSom()
    {
        Console.WriteLine("Som de mamífero");
    }

    public override void Locomover()
    {
        Console.WriteLine("Correndo");
    }
}
