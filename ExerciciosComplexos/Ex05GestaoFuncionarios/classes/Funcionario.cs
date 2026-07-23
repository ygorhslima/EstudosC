namespace Ex05GestaoFuncionarios
{
    public class Funcionario(string matricula, string nome, decimal salarioBase)
    {
        public string Matricula { get; set; } = matricula;
        public string Nome { get; set; } = nome;
        public decimal SalarioBase { get; set; } = salarioBase;

        public virtual decimal CalcularSalario()
        {
            return SalarioBase;
        }
    }
}