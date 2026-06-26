const float KM_LIMITE = 80;

Console.Write("Qual é a velocidade atual do carro?: ");
float VelocidadeAtual = float.Parse(Console.ReadLine() ?? string.Empty);

float multa = (VelocidadeAtual - KM_LIMITE) * 7f;

if(VelocidadeAtual < KM_LIMITE)
{
    Console.WriteLine("Tenha um bom dia! Dirija com segurança");
}
else
{
    Console.WriteLine($"MULTADO! Você excedeu o limite permitido que é de {KM_LIMITE}km/h ");
    Console.WriteLine($"Você deve pagar uma multa de R${multa}!");
    Console.WriteLine("Tenha um bom dia! Dirija com segurança");
}