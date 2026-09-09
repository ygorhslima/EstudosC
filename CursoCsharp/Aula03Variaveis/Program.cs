public class Program
{
    public static void Main(string[] args)
    {
        char letra = 'c';
        string nomeCompleto = "João Souza da Silva Neto";
     
        sbyte n1 = 10;
        byte n2 = 100;
        short n3 = 1000;
        int n4 = 1000000;
        long n5 = 100000000;
     
        double raio = 7.5;
        decimal salario = 50000;

        // o tipo variável é quando não especifico o tipo, mas é definido no ato da compilação
        var aux = 10;
        // isso por exemplo não pode acontecer => aux = "olá";

        Console.WriteLine($"""
        n1: {n1}
        n2: {n2}
        n3: {n3}
        n4: {n4}
        n5: {n5}
        raio: {raio}
        salario: {salario}
        aux: {aux}
        """);
    }
}
