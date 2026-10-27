using System;
public class Program
{
    public static void Main(string[] args)
    {
        ContaBanco c1 = new ContaBanco("Jubileu", 12947981);
        c1.AbrirConta("cc");
        c1.Depositar(100);

        ContaBanco c2 = new ContaBanco("Creuza", 2137914);
        c2.AbrirConta("cp");
        c2.Depositar(500);

        Console.WriteLine(c1.ToString());
        Console.WriteLine(c2.ToString());
    }
}