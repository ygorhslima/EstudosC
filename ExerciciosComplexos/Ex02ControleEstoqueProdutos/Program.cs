
using Ex02ControleEstoqueProdutos.FuncoesMenu;
public class Program
{
    public static void Main(string[] args)
    {
        var produtos = new List<Produto>();
        var funcoesMenu = new FuncoesMenu();
        int entrada = 999;
        while (entrada != 0)
        {
            funcoesMenu.Menu();
            entrada = int.Parse(Console.ReadLine() ?? "");
            switch (entrada)
            {
                case 0: // sair do programa
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Saindo do programa");
                    Console.ResetColor();
                    break;
                case 1:
                    funcoesMenu.AdicionarNovoProduto(produtos);
                    break;
                case 2:
                    funcoesMenu.VerTodosOsProdutos(produtos);
                    break;
                case 3:
                    funcoesMenu.ListarProdutosPelaCategoria(produtos);
                    break;
                case 4:
                    funcoesMenu.ListarProdutosComMaioresPrecos(produtos);
                    break;
                default:
                    Console.WriteLine("OBS: Escolha somente as opções do Menu");
                    break;
            }
        }
    }
}