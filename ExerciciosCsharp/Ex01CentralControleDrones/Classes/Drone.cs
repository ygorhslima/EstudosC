using System;
namespace Ex01CentralControleDrones;

public class Drone
{
    public int Codigo {get;set;}
    public string ?Modelo {get;set;}
    public float CapacidadeMaxima {get;set;}
    public int NivelBateria {get;set;}
    public string ?Status {get;set;}
    public int QuantEntregas {get;set;}

    public void Listar()
    {
        Console.WriteLine($"""
        ===========================================
        Codigo: {Codigo}
        Modelo: {Modelo}
        Capacidade Máxima: {CapacidadeMaxima}
        Nível de Bateria: {NivelBateria}
        Status: {Status}
        Quantidade de Entrega: {QuantEntregas}
        ===========================================
        """);
    }
}
