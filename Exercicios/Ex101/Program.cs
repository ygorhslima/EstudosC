/*
Faça um programa que leia nome e média de um aluno, guardando também a situação
em um dicionário, No final mostre o conteúdo da estrutura na tela.
Nome: João
Média do João: 6.5
-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
- nome é igual a João
- média é igual a 6.5
- situação é igual a Recuperação 
*/
namespace Exercicios.Ex101;
public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, object> aluno = [];
        Console.Write("Nome: ");
        aluno["nome"] = Console.ReadLine() ?? "";

        Console.Write($"Média do {aluno["nome"]}: ");
        double media = Convert.ToDouble(Console.ReadLine());
        aluno["media"] = media;

        if(media >= 7.0)
        {
            aluno["situacao"] = "Aprovado";
        }else if (media >= 5.0)
        {
            aluno["situacao"] = "Recuperação";
        }
        else
        {
            aluno["situacao"] = "Reprovado";
        }
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        foreach (KeyValuePair<string,object> item in aluno)
        {
            Console.WriteLine($"- {item.Key} é igual a {item.Value}");
        }
    }
}