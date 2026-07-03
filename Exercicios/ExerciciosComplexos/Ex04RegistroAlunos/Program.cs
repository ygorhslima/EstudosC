using Ex04RegistroAluno.Aluno;

public class Program
{
    public static void Main(string[] args)
    {
        var listaAlunos = new List<Aluno>();
        var funcoesMenuAlunos = new FuncoesMenuAlunos();
        int entrada = 999;

        while (entrada != 0)
        {
            funcoesMenuAlunos.Menu();
            Console.Write("Digite sua opção: ");
            entrada = int.Parse(Console.ReadLine() ?? "");
            switch (entrada)
            {
                case 0: // sair do programa
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Saindo do programa");
                    Console.ResetColor();
                    break;
                case 1: // adicionar aluno
                    funcoesMenuAlunos.AdicionarDados(listaAlunos);
                    break;
                case 2:
                    funcoesMenuAlunos.VisualizarDados(listaAlunos);
                    break;
                default:
                    Console.WriteLine("Escolha somente as opções acima");
                    break;
            }
        }
    }
}