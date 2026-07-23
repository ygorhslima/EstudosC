namespace Ex06SistemaGestaoEficienciaEnergica.Classes;

public class CarroEletrico(string id, string nome, double potenciaNominal, bool estaLigado, double capacidadeBateria, float percentualCarga) : Dispositivo(id, nome, potenciaNominal, estaLigado)
{
    public double CapacidadeBateria { get; set; } = capacidadeBateria;
    public float PercentualCarga { get; set; } = percentualCarga;
}