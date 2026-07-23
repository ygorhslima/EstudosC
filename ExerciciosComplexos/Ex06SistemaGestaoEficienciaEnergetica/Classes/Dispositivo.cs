namespace Ex06SistemaGestaoEficienciaEnergica.Classes;

public abstract class Dispositivo(string id, string nome, double potenciaNominal, bool estaLigado)
{
    public string Id { get; set; } = id;
    public string Nome { get; set; } = nome;
    public double PotenciaNominal { get; set; } = potenciaNominal;
    public bool EstaLigado { get; set; } = estaLigado;

    public virtual double CalcularConsumoMensal(int horasDiarias)
    {
        Console.WriteLine("Calculando Consumo mensal");
        return horasDiarias * 30;
    }
}