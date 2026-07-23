class FuncoesMenuGestaoContato : IFuncoesMenuGestaoContato
{
    public void AdicionarDados(List<Contato> contatos)
    {
        string resposta = "S";
        while (resposta != "N")
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine() ?? "";

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine() ?? "";

            Console.Write("Email: ");
            string email = Console.ReadLine() ?? "";

            contatos.Add(new Contato
            {
                Nome = nome,
                Telefone = telefone,
                Email = email
            });

            Console.Write("Quer continuar? [S/N]: ");
            resposta = Console.ReadLine() ?? "";
        }
    }

    public void BuscarContatoPeloNome(List<Contato> contatos)
    {
        if (contatos.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A lista de contatos está vazia");
            Console.ResetColor();
        }
        else
        {
            // nome digitado pelo usuário
            Console.Write("Nome: ");
            string entrada = (Console.ReadLine() ?? "").ToUpper();
            var listaFormatada = contatos.Where(c => c.Nome == entrada).ToList();
            VerTodosOsContatos(listaFormatada);
        }
    }

    public void VerTodosOsContatos(List<Contato> contatos)
    {
        if (contatos.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A lista de contatos está vazia");
            Console.ResetColor();
        }
        else
        {
            foreach (var item in contatos)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Lin("-=");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Telefone: {item.Telefone}");
                Console.WriteLine($"Email: {item.Email}");
                Lin("-=");
                Console.ResetColor();
            }
        }
    }

    public void Menu()
    {
        Lin("-=");
        Console.WriteLine("Sistema de gestão de contato");
        Lin("-=");
        Console.WriteLine("[0] Sair do Programa");
        Console.WriteLine("[1] Adicionar um contato");
        Console.WriteLine("[2] ver todos os contatos");
        Console.WriteLine("[3] buscar contato pelo nome");
        Lin("=*=");
    }

    public void Lin(string TipoLinha)
    {
        Console.WriteLine(string.Concat(Enumerable.Repeat($"{TipoLinha}", 20)));
    }
}