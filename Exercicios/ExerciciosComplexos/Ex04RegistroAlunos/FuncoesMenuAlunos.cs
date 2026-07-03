using Ex04RegistroAluno.Aluno;

public class FuncoesMenuAlunos : IFuncoesMenuAlunos
{
    public void AdicionarDados(List<Aluno> alunos)
    {
        string resposta = "S";
        while (resposta != "N")
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine() ?? "";

            Console.Write("Nota: ");
            float nota = float.Parse(Console.ReadLine() ?? "");

            Console.Write("Matricula: ");
            string matricula = Console.ReadLine() ?? "";

            alunos.Add(new Aluno
            {
                Nome = nome,
                Nota = nota,
                Matricula = matricula
            });

            Console.Write("Quer continuar [S/N]: ");
            resposta = Console.ReadLine() ?? "";
        }
    }

    public void VisualizarDados(List<Aluno> alunos)
    {
        foreach (var item in alunos)
        {
            Lin("-=");
            Console.WriteLine($"Nome: {item.Nome}");
            Console.WriteLine($"Nota: {item.Nota}");
            Console.WriteLine($"Matricula: {item.Matricula}");
            Lin("-=");
        }
    }

    public void Menu()
    {
        Lin("-=");
        Console.WriteLine("[0] Sair do Programa");
        Console.WriteLine("[1] Adicionar novo aluno");
        Console.WriteLine("[2] Visualizar alunos");
        Lin("-=");
    }

    public void Lin(string TipoLinha)
    {
        Console.WriteLine(string.Concat(Enumerable.Repeat($"{TipoLinha}", 20)));
    }
}