Console.Write("Quantos dias alugados?: ");
int dias = int.Parse(Console.ReadLine() ?? string.Empty);

Console.Write("Quantos km rodados: ");
double km = double.Parse(Console.ReadLine() ?? string.Empty);

double pago = (dias * 60) + (km * 0.15);
Console.WriteLine($"O total a pagar é de R${pago:F2}");