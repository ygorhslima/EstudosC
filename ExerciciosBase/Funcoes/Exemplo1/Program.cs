void Somar(float a, float b)
{
    float res = a + b;
    Console.WriteLine($"a soma entre {a} e {b} é {res}");
}

void Subtrair(float a, float b)
{
    float res = a - b;
    Console.WriteLine($"a subtração entre {a} e {b} é {res}");
}

void Multiplicar(float a, float b)
{
    float res = a * b;
    Console.WriteLine($"a multiplicação entre {a} e {b} é {res}");
}

void Dividir(float a, float b)
{
    float res = a / b;
    Console.WriteLine($"a divisão entre {a} e {b} é {res}");
}

int opcao = 0;

Console.Write("Digite o Primeiro Valor: ");
float n1 = float.Parse(Console.ReadLine());

Console.Write("Digite o Segundo Valor: ");
float n2 = float.Parse(Console.ReadLine());

while (opcao != 5)
{
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair do Programa");
    Console.Write("Digite sua opção de calculo: ");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1: Somar(n1,n2); break;
        case 2: Subtrair(n1,n2); break;
        case 3: Multiplicar(n1,n2); break;
        case 4: Dividir(n1,n2); break;
        case 5: Console.WriteLine("Saindo do programa"); break;
        default:
            Console.WriteLine("Erro");
            break;
    }
}