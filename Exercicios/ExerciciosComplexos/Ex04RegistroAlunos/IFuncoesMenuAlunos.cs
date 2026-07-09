using Ex04RegistroAluno.Aluno;

interface IFuncoesMenuAlunos
{
    void AdicionarAlunos(List<Aluno> alunos);
    void EditarAluno(List<Aluno> alunos);
    void RemoverAluno(List<Aluno> alunos);

    void BuscarTodosAlunos(List<Aluno> alunos);
    void BuscarAluno(List<Aluno> alunos);

    void Lin(string TipoLinha);
    void Menu();
}