class Program
{
    public static void Main(string[] args)
    {
        int v1, v2;
        Console.Write("Digite um valor: ");
        v1 = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Digite outro valor: ");
        v2 = int.Parse(Console.ReadLine() ?? "");
        int result = Somar(v1, v2);
        
        Console.WriteLine(result);
    }

    static int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
}