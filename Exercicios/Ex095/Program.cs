public class Dados
{
    public string Nome { get; set; } = "";
    public float Peso { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        string resposta = "S";
        List<Dados> lista_dados = new List<Dados>();
        while (resposta == "S".ToUpper())
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine() ?? "";

            Console.Write("Peso: ");
            float peso = float.Parse(Console.ReadLine() ?? "");

            lista_dados.Add(new Dados { Nome = nome, Peso = peso });

            Console.Write("Quer continuar? [S/N]: ");
            resposta = Console.ReadLine() ?? "";
            Console.WriteLine("------------------------------");
        }
        var quantPessoas = lista_dados.Count;

        float maiorPeso = lista_dados.Max(d => d.Peso);
        float menorPeso = lista_dados.Min(d => d.Peso);

        var maisPesados = lista_dados.Where(dado => dado.Peso == maiorPeso);
        var maisLeves = lista_dados.Where(dado => dado.Peso == menorPeso);

        Console.WriteLine($"Quantidade de pessoas cadastradas: {quantPessoas}");
        Console.WriteLine($"Maior peso ({maiorPeso}kg): [ {string.Join(" ", maisPesados.Select(p => p.Nome))} ]");
        Console.WriteLine($"Menor peso ({menorPeso}kg): [ {string.Join(" ", maisLeves.Select(p => p.Nome))} ]");
    }
}