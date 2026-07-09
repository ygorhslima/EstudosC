namespace Ex05GestaoFuncionarios
{
    public class Gerente : Funcionario
    {
        public decimal Bonus { get; set; }

        public Gerente(
            string matricula,
            string nome,
            decimal salarioBase,
            decimal bonus
        ) : base(matricula, nome, salarioBase)
        {
            Bonus = bonus;
        }
        
        public override decimal CalcularSalario()
        {
            return SalarioBase + Bonus;
        }
    }
}