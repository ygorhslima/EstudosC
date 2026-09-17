using System.Runtime.ExceptionServices;

class Program
{
    public static void Main(string[] args)
    {
        Soma(10,20,30);
    }
    
    static void Soma(params int[] n)
    {
        int res = 0;
        if(n.Length < 1)
        {
            Console.WriteLine("Não existem valores a serem somados");
        }else if (n.Length < 2)
        {
            Console.WriteLine("Valores insuficientes para soma");
        }
        else
        {
            for (int i = 0; i < n.Length; i++)
            {
                res += n[i];
            }
            Console.WriteLine($"A soma dos valores é: {res}");
        }
    }
}