Console.Write("Qual é o salário do funcionário?: R$");

double salario = double.Parse(Console.ReadLine() ?? string.Empty);
double aumento = salario * 0.15;

Console.WriteLine($"Um funcionário que ganhava R${salario}, com 15% de aumento, passa a receber R${aumento}");