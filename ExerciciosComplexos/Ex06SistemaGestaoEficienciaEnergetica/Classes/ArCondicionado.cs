namespace Ex06SistemaGestaoEficienciaEnergica.Classes;

public class ArCondicionado(string id, string nome, double potenciaNominal, bool estaLigado, int capacidadeBtu, bool mocoEco) : Dispositivo(id, nome, potenciaNominal, estaLigado)
{
    public int CapacidadeBTU { get; set; } = capacidadeBtu;
    public bool MocoECO { get; set; } = mocoEco;

}