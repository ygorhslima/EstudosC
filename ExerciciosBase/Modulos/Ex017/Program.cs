
Console.Write("Comprimento do cateto oposto: ");
double co = double.Parse(Console.ReadLine() ?? string.Empty);
Console.Write("Comprimento do cateto adjacente: ");
double ca = double.Parse(Console.ReadLine() ?? string.Empty);

double hipotenusa = Math.Sqrt(Math.Pow(co, 2) + Math.Pow(ca, 2));

Console.Write($"A hipotenusa vai medir {hipotenusa:F2}");