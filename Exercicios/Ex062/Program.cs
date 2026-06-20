public class Program
{
    public static void Main(string[] args)
    {
        var ListaIdades = new List<int>();
        int idade;
        string resultado = "S";
        while (resultado != "N")
        {
            Console.Write("Digite uma idade: ");
            idade = int.Parse(Console.ReadLine() ?? "");

            ListaIdades.Add(idade);
            Console.Write("Quer continuar [S/N]: ");
            resultado = Console.ReadLine() ?? "";
        }
        var mediaIdades = ListaIdades.Average();
        var idades21OuMais = ListaIdades.Count(idades => idades >= 21);

        Console.WriteLine($"Foram {ListaIdades.Count()} idades digitadas");
        Console.WriteLine($"A média de idades digitadas foi: {mediaIdades}");
        Console.WriteLine($"Quantidade de pessoas que tem 21 anos ou mais: {idades21OuMais}");
    }
}