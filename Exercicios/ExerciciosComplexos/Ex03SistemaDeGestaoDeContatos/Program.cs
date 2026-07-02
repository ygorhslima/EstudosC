public class Program
{
    public static void Main(string[] args)
    {
        var ListaContatos = new List<Contato>();
        var funcoesMenuGestaoContato = new FuncoesMenuGestaoContato();
        int entrada = 999;
        while (entrada != 0)
        {
            funcoesMenuGestaoContato.Menu();
            entrada = int.Parse(Console.ReadLine() ?? "");
            switch (entrada)
            {
                case 0: // sair do programa
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Saindo do programa");
                    Console.ResetColor();
                    break;
                case 1: // adicionar um contato
                    funcoesMenuGestaoContato.AdicionarDados(ListaContatos);
                    break;
                case 2: // ver todos os contatos
                    funcoesMenuGestaoContato.VerTodosOsContatos(ListaContatos);
                    break;
                case 3: // buscar contato pelo nome
                    funcoesMenuGestaoContato.BuscarContatoPeloNome(ListaContatos);
                    break;
                default:
                    Console.WriteLine("Escolha somente as opções acima");
                    break;
            }

        }
    }
}