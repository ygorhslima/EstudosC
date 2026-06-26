Console.Write("Digite um número: ");
double n = double.Parse(Console.ReadLine() ?? string.Empty);

double dobro = n * 2;
double triplo = n * 3;
double raizQ = Math.Sqrt(n);

Console.WriteLine($"O dobro de {n} vale {dobro}\nO triplo de {n} vale {triplo}\nA raiz quadrada de {n} é igual a {raizQ:F2}");