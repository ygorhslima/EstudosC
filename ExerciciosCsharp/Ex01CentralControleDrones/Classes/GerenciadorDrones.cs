using System;

namespace Ex01CentralControleDrones;

public class GerenciadorDrones
{
    private Drone[] Drones = new Drone[2];

    public void CadastrarDrone()
    {
        for (var i = 0; i < Drones.Length; i++)
        {
            Drone drone = new Drone();

            Console.Write("Código: ");
            drone.Codigo = int.Parse(Console.ReadLine() ?? "");
            
            Console.Write("Modelo: ");
            drone.Modelo = Console.ReadLine();
            
            Console.Write("Capacidade Máxima: ");
            drone.CapacidadeMaxima = float.Parse(Console.ReadLine() ?? "");
            
            Console.Write("Nível de Bateria: ");
            drone.NivelBateria = int.Parse(Console.ReadLine() ?? "");
            
            //(Disponível, Em operação ou Em manutenção).
            Console.Write("Status: ");
            drone.Status = Console.ReadLine() ?? "";
        
            Console.Write("Quantidade de Entregas: ");
            drone.QuantEntregas = int.Parse(Console.ReadLine() ?? "");

            Drones[i] = drone;
        }
    }

    public void ListarDrones()
    {
        for (var i = 0; i < Drones.Length; i++)
        {
            Drones[i].Listar();
        }
    }
    
    public void PesquisarDronePorCodigo(int codigo)
    {
        
    }
    public void ExibirDronesComBateriaBaixa()
    {
        
    }
}
