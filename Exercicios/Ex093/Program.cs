
public class Program
{
    public static void Main(string[] args)
    {
        var lista_numeros = new List<int>();
        string resposta = "S";

        while (resposta != "N")
        {
            Console.Write("Digite um valor: ");
            int numero = int.Parse(Console.ReadLine() ?? "");

            lista_numeros.Add(numero);

            Console.Write("Quer Continuar [S/N]: ");
            resposta = Console.ReadLine() ?? "";

            if (resposta == "N")
            {
                Console.WriteLine("Analisando os dados");
                break;
            }
        }
        lista_numeros.Reverse();

        Console.WriteLine($"Quantos numeros foram digitados?: {lista_numeros.Count()}");
        Console.Write($"Os valores ordenados de forma decrescente: [");
        lista_numeros.ForEach(item => Console.Write($" {item} "));
        Console.WriteLine("]");

        bool encontrarElemento5 = lista_numeros.Contains(5);
        string msg = encontrarElemento5 == true ? "sim":"nao";
        Console.WriteLine($"o valor 5 esta na lista?: {msg}");
        
    }
}