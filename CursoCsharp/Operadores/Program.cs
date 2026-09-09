public class Program
{
    public static void Main(string[] args)
    {
        int num = 10;
        // incremento
        num++;
        //num = num + 1;
        //num += 1;
        Console.WriteLine(num);

        num--;
        //num = num - 1;
        //num -= 1;
        //decremento
        Console.WriteLine(num);

        int num2 = 20;
        int num3 = 50;


        int soma = num2 + num3;
        int subtracao = num2 - num3;
        int multiplicacao = num2 * num3;
        int divisao = num2 / num3;

        Console.WriteLine($"{num2} + {num3} = {soma}");
        Console.WriteLine($"{num2} - {num3} = {subtracao}");
        Console.WriteLine($"{num2} * {num3} = {multiplicacao}");
        Console.WriteLine($"{num2} / {num3} = {divisao}");

        bool res = (90 > 5) && (10 > 20);
        Console.WriteLine(res);
    }    
}