namespace Ex06SistemaGestaoEficienciaEnergica.Interfaces;

// Apenas a LampadaInteligente e o ArCondicionado devem implementar esta interface.
public interface IProgramavel
{
    void AgendarFuncionamento(DateTime horario);
}