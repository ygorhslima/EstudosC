using System;

namespace Aula12;

public class Peixe(
    float peso, 
    int idade, 
    int membros, 
    string corEscama
) : Animal(peso, idade, membros)
{
    private string CorEscama = corEscama;

    public string getCorEscama()
    {
        return this.CorEscama;
    }

    public void setCorEscama(string CorEscama)
    {
        this.CorEscama = CorEscama;
    }


    public override void Alimentar()
    {
        Console.WriteLine("Comendo Substâncias");
    }

    public override void EmitirSom()
    {
        Console.WriteLine("Peixe não faz som");
    }

    public override void Locomover()
    {
        Console.WriteLine("Nadando");
    }

    public void SoltarBolha()
    {
        Console.WriteLine("Soltando bolha");
    }
}
