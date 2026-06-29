
using static Ex02ControleEstoqueProdutos.FuncoesMenu.FuncoesMenu;
public class Program
{
    public static void Main(string[] args)
    {
        var produtos = new List<Produto>();

        // flag para loop
        string resposta = "S";
        while (resposta != "N")
        {
            Lin("-=");
            Console.Write("Nome do Produto: ");
            string nome = Console.ReadLine() ?? "";

            Console.Write($"Preço do {nome}: ");
            float preco = float.Parse(Console.ReadLine() ?? "");

            Console.Write("Quantidade em estoque: ");
            int quantidadeEmEstoque = int.Parse(Console.ReadLine() ?? "");

            produtos.Add(new Produto { Nome = nome, Preco = preco, QuantidadeEmEstoque = quantidadeEmEstoque });

            Console.Write("Quer continuar[S/N]: ");
            resposta = Console.ReadLine() ?? "";
            Lin("-=");
        }

        int entrada = 999;
        while (entrada != 0)
        {
            Lin("=*=");
            Console.WriteLine("Que informações você quer saber: ");
            Console.WriteLine("[0] Sair do Programa");
            Console.WriteLine("[1] ver todos os produtos");
            Console.WriteLine("[2] listar os produtos com os maiores preços");
            Lin("=*=");
            entrada = int.Parse(Console.ReadLine() ?? "");
            switch (entrada)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Saindo do programa");
                    Console.ResetColor();
                    break;
                case 1:
                    VisualizarDados(produtos);
                    break;
                case 2:
                    ListarProdutosComMaioresPrecos(produtos);
                    break;
                default:
                    Console.WriteLine("OBS: Escolha somente as opções do Menu");
                    break;
            }
        }
    }
}