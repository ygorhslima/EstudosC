using System;

namespace Aula03;

public class Caneta
{
    public string Modelo;
    public string Cor;
    private float Ponta;
    protected int Carga;
    protected bool Tampada;

    public void Rabiscar()
    {
        Console.WriteLine("Rabiscando");
    }

    public void Tampar()
    {
        Tampada = true;
    }

    public string ToString()
    {
        return $"Modelo: {Modelo}\nCor: {Cor}\nPonta: {Ponta}\nCarga: {Carga}\nTampada: {Tampada}";
    }
}
