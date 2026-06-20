namespace Exercicios.Ex067;

public class Program
{
    public static void Main(string[] args)
    {
        var ListaPessoas = new List<Pessoa>();
        string resposta = "S";

        while (resposta != "N")
        {
            Console.Write("Sexo[M/F]: ");
            string sexo = Console.ReadLine() ?? "";

            Console.Write("Peso: ");
            float peso = float.Parse(Console.ReadLine() ?? "");

            ListaPessoas.Add(new Pessoa { Sexo = sexo, Peso = peso });

            Console.Write("Quer continuar [S/N]: ");
            resposta = Console.ReadLine() ?? "";
        }

        var mulheres = ListaPessoas.Where(pessoa => pessoa.Sexo == "F").ToList();
        var homens = ListaPessoas.Where(pessoa => pessoa.Sexo == "M").ToList();

        int totalMulheres = mulheres.Count;
        int homensMais100Kg = homens.Count(pessoa => pessoa.Peso > 100);

        var mediaPesoMulheres = mulheres.Any() ? mulheres.Average(pessoa => pessoa.Peso) : 0;
        var maiorPesoHomem = homens.Any() ? homens.Max(pessoa => pessoa.Peso) : 0;

        Console.WriteLine($"Quantidade de mulheres cadastradas: {totalMulheres}");
        Console.WriteLine($"Quantidade de homens que pesam mais de 100Kg: {homensMais100Kg}");
        Console.WriteLine($"A média de peso entre as mulheres: {mediaPesoMulheres}");
        Console.WriteLine($"O maior peso entre os homens foi de {maiorPesoHomem}");
    }
}