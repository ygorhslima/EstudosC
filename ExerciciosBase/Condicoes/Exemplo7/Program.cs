Console.WriteLine("Qual é a distância da sua viagem?:  ");
double distanciaViagem = double.Parse(Console.ReadLine() ?? string.Empty);
double preco = distanciaViagem <= 200 ? distanciaViagem * 0.50 : distanciaViagem * 0.45;
Console.WriteLine($"Você está prestes a começar uma viagem de {distanciaViagem:F2}Km");
Console.WriteLine($"E o preço da sua passagem será de R$ {preco:F2}");