float largura = float.Parse(Console.ReadLine() ?? string.Empty);
float altura = float.Parse(Console.ReadLine() ?? string.Empty);

float area = largura * altura;
float litrosTinta = area / 2;

Console.WriteLine($"Sua parede tem a dimensão de {largura}x{altura} e sua área é de {area}");
Console.WriteLine($"Para pintar essa parede, você precisará de {litrosTinta}l de tinta");