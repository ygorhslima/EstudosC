int a,b,c,max;

Console.WriteLine("Digite o primeiro número inteiro: ");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o Segundo número inteiro: ");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número inteiro: ");
c = int.Parse(Console.ReadLine());

if(a > b)
{
    if (a > c)
    {
        max = a;
    }
    else
    {
        max = c;
    }
}
else
{
    if(b > c)
    {
        max = b;
    }
    else
    {
        max = c;
    }
}

Console.WriteLine($"O maior é {max}");