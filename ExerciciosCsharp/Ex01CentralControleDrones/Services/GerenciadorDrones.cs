using System;
using Ex01CentralControleDrones.Models;
namespace Ex01CentralControleDrones.Services;

/*
3. Não permitir iniciar uma entrega se a bateria estiver abaixo de 30%.
4. Não permitir iniciar uma operação com drone em manutenção.
5. Ao realizar uma entrega, diminuir 30% da bateria.
6. Aumentar o contador de entregas realizadas.
7. Listar os drones que possuem bateria inferior a 20%.
*/

public class GerenciadorDrones
{
    private List<Drone> Drones = new List<Drone>();

    public void CadastrarDrone()
    {
        var drone = new Drone();

        Console.Write("Código: ");
        drone.Codigo = int.Parse(Console.ReadLine() ?? "");

        Console.Write("Modelo: ");
        drone.Modelo = Console.ReadLine();

        Console.Write("Capacidade Máxima: ");
        drone.CapacidadeMaxima = float.Parse(Console.ReadLine() ?? "");

        Console.Write("Nível de Bateria: ");
        drone.NivelBateria = int.Parse(Console.ReadLine() ?? "");
        
        Console.Write("Quantidade de Entregas: ");
        drone.QuantEntregas = int.Parse(Console.ReadLine() ?? "");

        Drones.Add(drone);
    }

    public void ListarDrones()
    {
        if (Drones.Count == 0)
        {
            Console.WriteLine("Nenhum drone cadastrado");
            return;
        }
        foreach (var drone in Drones)
        {
            drone.Listar();
        }
    }

    public void PesquisarDronePorCodigo()
    {
        if (Drones.Count == 0)
        {
            Console.WriteLine("Nenhum drone cadastrado");
            return;
        }
        int codigo;
        Console.Write("código do drone: ");
        codigo = int.Parse(Console.ReadLine() ?? "");
        foreach (var item in Drones)
        {
            if (item.Codigo == codigo)
            {
                item.Listar();
            }
        }
    }

    public void ExibirDronesComBateriaBaixa()
    {
        if (Drones.Count == 0)
        {
            Console.WriteLine("Nenhum drone cadastrado");
            return;
        }
        foreach (var item in Drones)
        {
            if (item.NivelBateria < 20)
            {
                item.Listar();
            }
        }
    }

    public void IniciarOperacaoDeEntrega()
    {
        if (Drones.Count == 0)
        {
            Console.WriteLine("Nenhum drone cadastrado");
            return;
        }
        int codigo;
        Console.Write("código do drone: ");
        codigo = int.Parse(Console.ReadLine() ?? "");
        foreach (var item in Drones)
        {
            if (item.Codigo == codigo)
            {
                item.Entregar();
            }
        }
    }

    public void RecarregarBateria()
    {
        if (Drones.Count == 0)
        {
            Console.WriteLine("Nenhum drone cadastrado");
            return;
        }
        int codigo;
        Console.Write("código do drone: ");
        codigo = int.Parse(Console.ReadLine() ?? "");
        foreach (var item in Drones)
        {
            if (item.Codigo == codigo)
            {
                item.Recarregar();
            }
        }
    }

    public void EnviarDroneParaManutencao()
    {
        if (Drones.Count == 0)
        {
            Console.WriteLine("Nenhum drone cadastrado");
            return;
        }
        int codigo;
        Console.Write("código do drone: ");
        codigo = int.Parse(Console.ReadLine() ?? "");
        foreach (var item in Drones)
        {
            if(item.Codigo == codigo)
            {
                item.FazerManutencao();
            }
        }
    }
}
