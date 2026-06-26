Console.Write("Digite o ângulo que você deseja: ");
double angulo = double.Parse(Console.ReadLine() ?? string.Empty);

double SENO = Math.Sin(angulo);
double COSSENO = Math.Cos(angulo);
double TANGENTE = Math.Tan(angulo);

Console.WriteLine($"O ângulo de {angulo} tem o SENO de {SENO:F2}");
Console.WriteLine($"O ângulo de {angulo} tem o COSSENO de {COSSENO:F2}");
Console.WriteLine($"O ângulo de {angulo} tem o TANGENTE de {TANGENTE:F2}");
