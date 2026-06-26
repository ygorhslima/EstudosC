Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();

Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

if(idade >= 65)
{
    Console.WriteLine("Idoso");
}else if(idade < 18)
{
    Console.WriteLine("Menor de idade");
}
else
{
    Console.WriteLine("Maior de idade");
}