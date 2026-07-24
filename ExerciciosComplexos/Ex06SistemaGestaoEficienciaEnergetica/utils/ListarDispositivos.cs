using Ex06SistemaGestaoEficienciaEnergica.Classes;

namespace Ex06SistemaGestaoEficienciaEnergica.utils;

public class ListarDispositivos
{
    public void ListarArCondicionado(List<ArCondicionado> listAr)
    {
        if (listAr.Count == 0)
        {
            Console.WriteLine("Nenhum ar-condicionado cadastrado.");
            return;
        }
        foreach (var arCondicionado in listAr)
        {
            Console.WriteLine($"ID: {arCondicionado.Id} \n Nome: {arCondicionado.Nome} \n BTU: {arCondicionado.CapacidadeBTU} \n ECO: {arCondicionado.ModoECO} \n Ligado: {arCondicionado.EstaLigado}");
        }
    }
    public void ListarLampadas(List<LampadaInteligente> listLamp)
    {
        if (listLamp.Count == 0)
        {
            Console.WriteLine("Nenhuma lâmpada cadastrada.");
            return;
        }
        foreach (var lampada in listLamp)
        {
            // Usando Console.WriteLine para exibir na tela
            Console.WriteLine($"ID: {lampada.Id} \n Nome: {lampada.Nome} \n Cor: {lampada.TemperaturaCor}K \n Ligado: {lampada.EstaLigado}");
        }
    }
    public void ListarCarroEletrico(List<CarroEletrico> listCar)
    {
        if (listCar.Count == 0)
        {
            Console.WriteLine("Nenhum carro elétrico cadastrado.");
            return;
        }
        foreach (var carroEletrico in listCar)
        {
            Console.WriteLine($"ID: {carroEletrico.Id} \n Nome: {carroEletrico.Nome} \n Bateria: {carroEletrico.CapacidadeBateria}kWh \n Carga: {carroEletrico.PercentualCarga}% \n Ligado: {carroEletrico.EstaLigado}");
        }
    }
}