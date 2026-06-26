using System;

namespace Aula12;

public class Reptil(
    float peso, 
    int idade, 
    int membros, 
    string corEscama
) : Animal(peso, idade, membros)
{
    private string CorEscama = corEscama;

    public string GetCorEscama()
    {
        return this.CorEscama;
    }

    public void SetCorEscama(string CorEscama)
    {
        this.CorEscama = CorEscama;
    }


    public override void Alimentar()
    {
        Console.WriteLine("Comendo Vegetais");
    }

    public override void EmitirSom()
    {
        Console.WriteLine("Som de réptil");
    }

    public override void Locomover()
    {
        Console.WriteLine("Rastejando");
    }
}
