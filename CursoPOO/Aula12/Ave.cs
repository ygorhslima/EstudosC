using System;

namespace Aula12;

public class Ave(
    float peso, 
    int idade, 
    int membros,
    string corPena
) : Animal(peso, idade, membros)
{
    private string CorPena = corPena;

    public string GetCorPena()
    {
        return this.CorPena;
    }

    public void SetCorPena(string CorPena)
    {
        this.CorPena = CorPena;
    }

    public override void Alimentar()
    {
        Console.WriteLine("Comendo frutas");
    }

    public override void EmitirSom()
    {
        Console.WriteLine("Som de ave");
    }

    public override void Locomover()
    {
        Console.WriteLine("Voando");
    }
    public void FazerNinho()
    {
        Console.WriteLine("Fazendo ninho");
    }
}
