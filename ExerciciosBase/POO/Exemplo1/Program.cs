public class Aluno
{
    public string Nome {get;set;}
    public float Nota1 {get;set;}
    public float Nota2 {get;set;}
    public float Nota3 {get;set;}
    public float Nota4 {get;set;}

    public void MostrarDados()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("nota1: " + Nota1);
        Console.WriteLine("nota2: " + Nota2);
        Console.WriteLine("nota3: " + Nota3);
        Console.WriteLine("nota4: " + Nota4);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Aluno n = new Aluno();

        Console.Write("Informe o nome do aluno: ");
        n.Nome = Console.ReadLine() ?? string.Empty;
        
        Console.Write("Nota 1: ");
        n.Nota1 = float.Parse(Console.ReadLine() ?? string.Empty);

        Console.Write("Nota 2: ");
        n.Nota2 = float.Parse(Console.ReadLine() ?? string.Empty);
        
        Console.Write("Nota 3: ");
        n.Nota3 = float.Parse(Console.ReadLine() ?? string.Empty);

        Console.Write("Nota 4: ");
        n.Nota4 = float.Parse(Console.ReadLine() ?? string.Empty);
        
        n.MostrarDados();
    
    }
}
