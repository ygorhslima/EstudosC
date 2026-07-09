namespace Ex05GestaoFuncionarios.Interface
{
    public interface IFuncoesMenu
    {
        public void Lin(string tipoLinha);
        public void Menu();
        public void CadastrarGerente(List<Funcionario> funcionarios);
        public void CadastrarDesigner(List<Funcionario> funcionarios);
        public void VisualizarTodos(List<Funcionario> funcionarios);
        public void BuscarPorMatricula(List<Funcionario> funcionarios);
        public void RemoverFuncionario(List<Funcionario> funcionarios);
    }
}