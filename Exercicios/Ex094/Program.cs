public class Program
{
    public static void Main(string[] args)
    {
        string resposta = "S";
        var lista_numero = new List<int>();
        var lista_numero_pares = new List<int>();
        var lista_numero_impares = new List<int>();

        while (resposta != "N")
        {
            Console.Write("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine() ?? "");

            if (numero % 2 == 0)
            {
                lista_numero_pares.Add(numero);
            }
            if (numero % 2 == 1)
            {
                lista_numero_impares.Add(numero);
            }

            Console.Write("Quer Continuar [S/N]: ");
            resposta = Console.ReadLine() ?? "";

            if (resposta == "N")
            {
                break;
            }
        }

        Console.WriteLine("A lista completa e: ");
        Console.Write("[");
        foreach (var item in lista_numero) Console.Write($" {item} ");
        Console.WriteLine("]");
        
        Console.WriteLine("A lista completa de pares: ");
        Console.Write("[");
        foreach (var item in lista_numero_pares) Console.Write($" {item} ");
        Console.WriteLine("]");

        Console.WriteLine("A lista completa de pares: ");
        Console.Write("[");
        foreach (var item in lista_numero_pares) Console.Write($" {item} ");
        Console.Write("]");
        
    }
}