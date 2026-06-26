Console.Write("Quanto dinheiro você tem na carteira: R$");
float dinheiro = float.Parse(Console.ReadLine() ?? string.Empty);

float real = 0.20f;
float dolar = dinheiro * real; 

Console.WriteLine($"Com R${dinheiro} você pode comprar US${dolar:F2}");