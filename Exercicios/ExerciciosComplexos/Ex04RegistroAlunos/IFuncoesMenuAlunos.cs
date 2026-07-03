using Ex04RegistroAluno.Aluno;

interface IFuncoesMenuAlunos
{
    void AdicionarDados(List<Aluno> alunos);
    void VisualizarDados(List<Aluno> alunos);
    void Lin(string TipoLinha);
    void Menu();
}