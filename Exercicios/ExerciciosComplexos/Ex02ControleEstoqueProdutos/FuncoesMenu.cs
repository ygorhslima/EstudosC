namespace Ex02ControleEstoqueProdutos.FuncoesMenu;

public static class FuncoesMenu
{

    public static void ListarProdutosComMaioresPrecos(List<Produto> produtos)
    {
        // 1. Verificar se a lista não está vazia
        if (produtos.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A lista de produtos está vazia");
            Console.ResetColor();
        }

        // 2. preciso do usuário para obter um valor de referência
        Console.Write("Listar produtos com preço acima de qual valor?: ");
        float valorReferencia = float.Parse(Console.ReadLine() ?? "");

        // 3. Filtrar os dados
        var valoresFiltrados = produtos.Where(p => p.Preco > valorReferencia).ToList();

        if (valoresFiltrados.Any())
        {
            Console.WriteLine($"Produtos com preço superiores a {valorReferencia}");
            VisualizarDados(valoresFiltrados);
        }
        else
        {
            Console.WriteLine("Nenhum produto encontrado acima desse valor.");
        }
    }

    public static void VisualizarDados(List<Produto> produtos)
    {
        foreach (var item in produtos)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine($"Nome: {item.Nome}");
            Console.WriteLine($"Preço: {item.Preco}");
            Console.WriteLine($"Quantidade em Estoque: {item.QuantidadeEmEstoque}");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.ResetColor();
        }
    }

    public static void Lin(string TipoLinha)
    {
        Console.WriteLine(string.Concat(Enumerable.Repeat($"{TipoLinha}", 20)));
    }
}
