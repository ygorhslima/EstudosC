public class Program
{
    public static void Main(string[] args)
    {
        var lista_numero = new List<int>();
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Digite um valor: ");
            int numero = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine($"Adicionando na posição {i} da lista");
            lista_numero.Add(numero);
        }
        lista_numero.ForEach(item=>Console.WriteLine($"[item]"));
    }    
}