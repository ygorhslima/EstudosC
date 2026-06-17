public class Pessoa
{
    public string Nome { get; set; } = "";
    public float Peso { get; set; }
}

public class Program
{

    public static void Main(string[] args)
    {
        var listaPessoas = new List<Pessoa>();
        string resposta = "S";
       
        while (resposta.ToUpper() != "N")
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine() ?? "";
            Console.Write("Peso: ");
            float peso = float.Parse(Console.ReadLine() ?? "");
            listaPessoas.Add(new Pessoa { Nome = nome, Peso = peso });
            Console.Write("Quer continuar [S/N]: ");
            resposta = (Console.ReadLine() ?? "").ToUpper();
        }

        float maiorPeso = listaPessoas.Max(p => p.Peso);
        float menorPeso = listaPessoas.Min(p => p.Peso);

        Console.Write($"O maior peso foi de {maiorPeso}kg. Peso de: ");

        var maisPesado = listaPessoas.Where(pessoa => pessoa.Peso == maiorPeso);
        foreach (var p in maisPesado)
        {
            Console.WriteLine($"[{p.Nome}]");
        }

        Console.WriteLine();
        Console.Write($"O menor peso foi de {menorPeso}kg. Peso de: ");
        var maisLeves = listaPessoas.Where(p => p.Peso == menorPeso);
        foreach (var p in maisLeves)
        {
            Console.Write($"[{p.Nome}] ");
        }
        Console.WriteLine();
    }
}