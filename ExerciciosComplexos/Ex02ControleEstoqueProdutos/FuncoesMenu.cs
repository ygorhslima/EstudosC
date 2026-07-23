namespace Ex02ControleEstoqueProdutos.FuncoesMenu;

public class FuncoesMenu : IFuncoesMenu
{
    public void ListarProdutosComMaioresPrecos(List<Produto> produtos)
    {
        // 1. Verificar se a lista não está vazia
        if (produtos.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A lista de produtos está vazia");
            Console.ResetColor();
            return;
        }
        else
        {
            // 2. preciso do usuário para obter um valor de referência
            Console.Write("Listar produtos com preço acima de qual valor?: ");
            float valorReferencia = float.Parse(Console.ReadLine() ?? "");

            // 3. Filtrar os dados
            var valoresFiltrados = produtos.Where(p => p.Preco > valorReferencia).ToList();

            if (valoresFiltrados.Any())
            {
                Console.WriteLine($"Produtos com preço superiores a {valorReferencia}");
                VerTodosOsProdutos(valoresFiltrados);
            }
            else
            {
                Console.WriteLine("Nenhum produto encontrado acima desse valor.");
            }
        }
    }

    public void VerTodosOsProdutos(List<Produto> produtos)
    {
        // 1. Verificar se a lista não está vazia
        if (produtos.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A lista de produtos está vazia");
            Console.ResetColor();
        }
        else
        {
            foreach (var item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco}");
                Console.WriteLine($"Quantidade em Estoque: {item.QuantidadeEmEstoque}");
                Console.WriteLine($"Categoria: {item.Categoria}");
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.ResetColor();
            }
        }
    }

    public void Lin(string TipoLinha)
    {
        Console.WriteLine(string.Concat(Enumerable.Repeat($"{TipoLinha}", 20)));
    }

    public void Menu()
    {
        Lin("-=");
        Console.WriteLine("SISTEMA DE CONTROLE DE ESTOQUE DE PRODUTOS");
        Lin("-=");
        Console.WriteLine("[0] Sair do Programa");
        Console.WriteLine("[1] Adicionar um produto");
        Console.WriteLine("[2] ver todos os produtos");
        Console.WriteLine("[3] listar produtos pela categoria");
        Console.WriteLine("[4] listar os produtos com os maiores preços");
        Lin("=*=");
    }

    public void AdicionarNovoProduto(List<Produto> produtos)
    {
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

            Console.WriteLine("Categoria:");
            Console.WriteLine("[0] Eletrônicos | [1] Games | [2] Livros | [3] Casa");
            string escolha = Console.ReadLine() ?? "0";
            string cat = escolha switch
            {
                "0" => "Eletrônicos",
                "1" => "Games e Console",
                "2" => "Livros",
                "3" => "Casa",
                _ => "Outros"
            };

            produtos.Add(new Produto { Nome = nome, Preco = preco, QuantidadeEmEstoque = quantidadeEmEstoque, Categoria = cat });

            Console.Write("Quer continuar[S/N]: ");
            resposta = Console.ReadLine() ?? "";
            Lin("-=");
        }
    }

    public void ListarProdutosPelaCategoria(List<Produto> produtos)
    {
        // 1. Verificar se a lista não está vazia
        if (produtos.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A lista de produtos está vazia");
            Console.ResetColor();
            return;
        }
        else
        {
            Console.WriteLine("Escolha a categoria de produtos que você quer visualizar:");
            Console.WriteLine("[0] Eletrônicos | [1] Games | [2] Livros | [3] Casa");
            string escolha = Console.ReadLine() ?? "0";
            string cat = escolha switch
            {
                "0" => "Eletrônicos",
                "1" => "Games e Console",
                "2" => "Livros",
                "3" => "Casa",
                _ => "Outros"
            };
            var valoresFiltrados = produtos.Where(p=>p.Categoria == cat).ToList();
            VerTodosOsProdutos(valoresFiltrados);
        }
    }
}