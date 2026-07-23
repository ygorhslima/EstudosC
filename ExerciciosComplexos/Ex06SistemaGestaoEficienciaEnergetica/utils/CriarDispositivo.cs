using Ex06SistemaGestaoEficienciaEnergica.Classes;

namespace Ex06SistemaGestaoEficienciaEnergica.utils;

public class CriarDispositivo
{
    public LampadaInteligente CriarLampada(string id, string nome, double potencia)
    {
        Console.Write("Temperatura da Cor (K): ");
        int.TryParse(Console.ReadLine(), out int cor);
        return new LampadaInteligente(id, nome, potencia, true, cor);
    }
    public ArCondicionado CriarArCondicionado(string id, string nome, double potencia)
    {
        Console.Write("Capacidade BTU: ");
        int.TryParse(Console.ReadLine(), out int btu);
        Console.Write("Modo Eco (s/n): ");
        bool eco = (Console.ReadLine() ?? "").ToLower() == "s";
        return new ArCondicionado(id, nome, potencia, true, btu, eco);
    }
    public CarroEletrico CriarCarroEletrico(string id, string nome, double potencia)
    {
        Console.Write("Capacidade Bateria (kWh): ");
        double.TryParse(Console.ReadLine(), out double bat);
        Console.Write("Percentual de Carga (%): ");
        float.TryParse(Console.ReadLine(), out float carga);
        return new CarroEletrico(id, nome, potencia, false, bat, carga);
    }
}