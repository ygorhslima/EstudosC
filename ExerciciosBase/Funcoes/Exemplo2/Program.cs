static int Soma(int X)
{
    int total = 0;
    for (int i = 1; i < X; i++)
    {
        total += i;

    }
    return total;
}

Console.Write("Informe um número: ");
int n = int.Parse(Console.ReadLine());

int resultado = Soma(n);
Console.WriteLine($"O somatório é: {resultado}");