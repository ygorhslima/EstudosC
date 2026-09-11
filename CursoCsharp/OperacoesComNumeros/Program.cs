public class Program
{
    public static void Main(string[] args)
    {
        // Parse e TryParse
        string texto = "42";
        int numero = int.Parse(texto); // 42

        if (int.TryParse("123", out int resultado))
        {
            Console.WriteLine($"Convertido com sucesso: {resultado}");
        }

        // ToString com formatação
        string hex = numero.ToString("X"); // "2A"
    }    
}