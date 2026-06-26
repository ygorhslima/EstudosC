static void Linha()
{
    string repetido = string.Concat(Enumerable.Repeat("-=", 20));
    Console.WriteLine(repetido);
}

Random valorGerado = new();

Linha();
Console.WriteLine("Vou pensar em um número entre 0 e 5. Tente adivinhar...");
Linha();
var computador = valorGerado.Next(0, 5);

Console.WriteLine("Em que número eu pensei?: ");
int jogador = int.Parse(Console.ReadLine() ?? string.Empty);

Console.WriteLine("PROCESSANDO...");
Thread.Sleep(2000);

if (computador == jogador)
{
    Console.WriteLine("PARABÉNS! Você conseguiu me vencer");
}
else if (jogador > 5)
{
    Console.WriteLine("O combinado não foi esse, é um número entre 0 e 5 :(");
}
else if (computador != jogador)
{
    Console.WriteLine($"GANHEI! Eu pensei no número {computador} e não no {jogador}!");
}