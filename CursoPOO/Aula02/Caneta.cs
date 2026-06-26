using System;

namespace Aula02;

public class Caneta
{
    public string Modelo;
    public string Cor;
    public float Ponta;
    public int Carga;
    public bool Tampada;

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
