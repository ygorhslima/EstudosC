Console.Write("Digite um número: ");
int n = int.Parse(Console.ReadLine() ?? string.Empty);

Console.WriteLine($"Analisando o valor {n}, o seu antecessor é {n-1} e o sucessor é {n+1}");