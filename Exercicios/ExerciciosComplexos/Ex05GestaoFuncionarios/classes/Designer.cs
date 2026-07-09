namespace Ex05GestaoFuncionarios
{
    public class Designer : Funcionario
    {
        public string FerramentaPrincipal { get; set; }

        public Designer(
            string matricula,
            string nome,
            decimal salarioBase,
            string ferramentaPrincipal
        ) : base(matricula, nome, salarioBase)
        {
            FerramentaPrincipal = ferramentaPrincipal;
        }

        
    }
}