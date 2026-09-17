public class Program
{
    public static void Main(string[] args)
    {
        int num = 10;
        // passagem por referência
        // usa o endereço de memória da variável ao qual foi passado como argumento
        dobrar(ref num);
        Console.WriteLine(num);
    }

    static void dobrar(ref int valor)
    {
        valor *= 2;
    }
}