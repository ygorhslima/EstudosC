/*
Crie um programa que leia nome, sexo e idade de várias pessoas, guardando os dados de cada pessoa em um dicionário e todos os dicionários em uma lista, no final, mostre:

A) quantas pessoas cadastradas
B) A média de idade.
C) Uma lista com mulheres
D) Uma lista com idade acima da média

Nome: Joao
Sexo: M
Idade: 40
Quer continuar [S/N]: S

Nome: maria
Sexo: F
Idade: 43
Quer continuar [S/N]: S

Nome: José
Sexo: M
Idade: 23
Quer continuar [S/N]: S

Nome: Geraldo
Sexo: M
Idade: 50
Quer continuar [S/N]: S

Nome: Mariana
Sexo: F
Idade: 20
Quer continuar [S/N]: N

A) Ao todo temos 5 pessoas cadastradas
B) A média de idade é de 35 anos.
As mulheres cadastradas foram: [maria, Mariana]
*/
namespace Exercicios.Ex105;

public class Program
{
    public static void Main(string[] args)
    {
        int cont = 0;
        int somaIdade = 0;
        string resposta = "S";
        var ListaGeral = new List<Dictionary<string, object>>();

        while (resposta == "S")
        {
            var DadosPessoa = new Dictionary<string, object>();

            Console.Write("Nome: ");
            DadosPessoa["nome"] = Console.ReadLine() ?? "";

            string sexo;
            while (true)
            {
                Console.Write("Sexo: ");
                sexo = Console.ReadLine() ?? "";
                if (sexo == "M" || sexo == "F") break;
                Console.WriteLine("ERRO! Por favor, digite apenas M ou F.");
            }
            DadosPessoa["sexo"] = sexo;

            Console.Write("Idade: ");
            DadosPessoa["idade"] = int.Parse(Console.ReadLine() ?? "");

            cont++;
            somaIdade += (int)DadosPessoa["idade"];
            ListaGeral.Add(DadosPessoa);

            while (true)
            {
                Console.Write("Quer continuar [S/N]: ");
                resposta = (Console.ReadLine() ?? "").ToUpper();
                if (resposta == "S" || resposta == "N")
                {
                    break;
                }
                Console.WriteLine("ERRO! Por favor, digite apenas S ou N.");
            }
            Console.WriteLine();
        }

        float mediaIdade = somaIdade / cont;
        List<string> ListaMulheres = [
            ..ListaGeral
            .Where(pessoa => pessoa["sexo"].ToString() == "F")
            .Select(pessoa => pessoa["nome"].ToString())
        ];

        List<string> ListaIdadeAcimaDaMedia = [
            ..ListaGeral
            .Where(pessoa => (int) pessoa["idade"] > mediaIdade)
            .Select(pessoa =>$"nome = {pessoa["nome"]}; sexo = {pessoa["sexo"]}; idade = {pessoa["idade"]}")
        ];


        Console.WriteLine($"A) Ao todo temos {cont} pessoas cadastradas");
        Console.WriteLine($"B) A média de idade é de {mediaIdade} anos.");
        Console.WriteLine($"As mulheres cadastradas foram: [{string.Join(", ", ListaMulheres)}]");
        Console.WriteLine($"lista com idades acima da média: ");
        foreach (var linha in ListaIdadeAcimaDaMedia) Console.WriteLine($"{linha}");

    }
}