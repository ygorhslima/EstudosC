public class Program
{
    public static void Main(string[] args)
    {        
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        
        Console.WriteLine($"olá {nome}");

        Console.Write("Digite o ano de nascimento: ");
        int year = int.Parse(Console.ReadLine());

        int currentYear = DateTime.Now.Year;
        int age = currentYear - year;

        Console.WriteLine($"Você tem {age} anos");

        if (age >= 18)
        {
            Console.WriteLine("Você é maior de idade");
        }
        else
        {
          Console.WriteLine("Você é menor de idade");
        }
    }    
}