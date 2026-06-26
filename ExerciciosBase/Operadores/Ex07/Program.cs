Console.Write("Primeira nota do aluno: ");
float n1 = float.Parse(Console.ReadLine() ?? string.Empty);

Console.Write("Segunda nota do aluno: ");
float n2 = float.Parse(Console.ReadLine() ?? string.Empty);

float media = (n1 + n2) / 2;
Console.WriteLine($"A média entre {n1} e {n2} é igual a {media:F2}");