using Ex06SistemaGestaoEficienciaEnergica.Interfaces;

namespace Ex06SistemaGestaoEficienciaEnergica.Classes;

public class LampadaInteligente(
    string id,
    string nome,
    double potenciaNominal,
    bool estaLigado,
    int temperaturaCor
    ) : Dispositivo(id, nome, potenciaNominal, estaLigado)
{
    public int TemperaturaCor { get; set; } = temperaturaCor;
    
}
