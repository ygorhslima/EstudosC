Console.WriteLine("Informe um número: ");
int n = int.Parse(Console.ReadLine() ?? string.Empty);

int u = n % 10;
int d = n % 100 / 10;
int c = n / 100;

Console.WriteLine($"\nNúmero: {n}");
Console.WriteLine($"Centena: {c}");
Console.WriteLine($"Dezena: {d}");
Console.WriteLine($"Unidade: {u}");