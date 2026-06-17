class Program
{
    public static void Main(string[] args)
    {
        int jogador, computador;
        Random valorAleatorio = new Random();
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= JOPENKO -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("Escolha uma das opções abaixo: ");
        Console.WriteLine("[1] Pedra");
        Console.WriteLine("[2] Papel");
        Console.WriteLine("[3] Tesoura"); 
        Console.WriteLine("[0] Sair do Programa");
        Console.Write("Digite sua opção: ");
        jogador = int.Parse(Console.ReadLine() ?? "");
        computador = valorAleatorio.Next(1, 4);

        if (jogador == 0)
        {
            Console.WriteLine("Saindo do programa...");
            return;
        }

        if (jogador < 1 || jogador > 3)
        {
            Console.WriteLine("ERRO! Escolha uma das opções do menu");
        }

        string[] opcoes = { "", "pedra", "papel", "tesoura" };
        Console.WriteLine($"Jogador escolheu: {opcoes[jogador]}");
        Console.WriteLine($"Computador escolheu: {opcoes[computador]}");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        if (jogador == computador)
        {
            Console.WriteLine("EMPATE");
        }else if (
            (jogador == 1 && computador == 3) ||
            (jogador == 3 && computador == 2) ||
            (jogador == 2 && computador == 1)
        )
        {
            Console.WriteLine("VOCÊ VENCEU");
        }
        else
        {
            Console.WriteLine("COMPUTADOR VENCEU");
        }
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    }
}