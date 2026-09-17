public class Program
{
    public static void Main(string[] args)
    {
        int divd, divs, quoc, rest;
        divd = 10;
        divs = 5;
        quoc = divite(divd, divs, out rest);
        Console.WriteLine($"{divd}/{divs}: quociente={quoc} e resto={rest}");
    }

    static int divite(int dividendo, int divisor, out int resto)
    {
        int quociente;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        return quociente;
    }
}