Console.WriteLine("Me diga um número qualquer: ");
int n = int.Parse(Console.ReadLine() ?? string.Empty);

if(n % 2 == 0)
{
    Console.WriteLine($"O número {n} é Par");
}
else
{
    Console.WriteLine($"O número {n} é Impar");
}