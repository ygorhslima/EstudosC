using System;
namespace Ex01CentralControleDrones.Models;
public class Drone
{
    public int Codigo {get;set;}
    public string ?Modelo {get;set;}
    public float CapacidadeMaxima {get;set;}
    public int NivelBateria {get;set;}
    public int QuantEntregas {get;set;}
    public bool EmManutencao {get;set;}
    public bool EmOperacao {get;set;}

    public void Listar()
    {
        Console.WriteLine($"""
        ===========================================
        Codigo: {Codigo}
        Modelo: {Modelo}
        Capacidade Máxima: {CapacidadeMaxima}
        Nível de Bateria: {NivelBateria}
        Status: {(EmManutencao ? "Em Manutenção" : (EmOperacao ? "Em Operação":"Disponível"))}
        Quantidade de Entrega: {QuantEntregas}
        ===========================================
        """);
    }

    public void Recarregar()
    {
        this.NivelBateria = 100;
    }

    // Não permitir iniciar uma entrega se a bateria estiver abaixo de 30%.
    public void Entregar()
    {
        if(NivelBateria < 30)
        {
            Console.WriteLine("Bateria insuficiente para iniciar a entrega");
            return;
        }
        if(EmOperacao)
        {
            Console.WriteLine("ERRO! Drone em operação");
            return;
        }
        if (EmManutencao)
        {
            Console.WriteLine("ERRO! Drone em Manutenção");
            return;
        }
        
        // a cada entrega, diminui-se 30% da bateria
        NivelBateria -= 30;

        // aumenta a quantidade de entrega mais 1
        QuantEntregas++;

        EmOperacao = true;
        Console.WriteLine("Entrega iniciada com sucesso");
    }

    public void FazerManutencao()
    {
        if (EmOperacao)
        {
            Console.WriteLine("ERRO! Drone em operação");
        }
        EmManutencao = true;
        Console.WriteLine("Drone enviado para a manutenção com sucesso!");
    }
}
