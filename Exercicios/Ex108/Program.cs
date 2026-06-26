namespace Exercicios.Ex108;
public class Program
{
    public static void Main(string[] args)
    {
        var moeda = new Moeda();
        Console.Write("Digite o preço: R$");
        float preco = float.Parse(Console.ReadLine() ?? "");

        Console.WriteLine($"A metade de {preco} é {moeda.Metade(preco)}");
        Console.WriteLine($"O dobro de {moeda.MoedaFormatacao(preco)} é {moeda.Dobro(preco)}");
        Console.WriteLine($"Aumentando 10%, temos {moeda.Aumentar(preco, 10)}");
    }
}