using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicios.Ex103;

public class Program
{
    public static void Main(string[] args)
    {
        var dadosValores = new Dictionary<string, object>();
        Console.Write("Nome: ");
        dadosValores["nome"] = Console.ReadLine() ?? "";
        
        Console.Write("Ano de nascimento: ");
        int nascimento = int.Parse(Console.ReadLine() ?? "0");
        
        int anoAtual = DateTime.Now.Year;
        dadosValores["idade"] = anoAtual - nascimento;
       
        Console.Write("Carteira de Trabalho (0 não tem): ");
        dadosValores["ctps"] = int.Parse(Console.ReadLine() ?? "0");

        // CORREÇÃO: Como 'ctps' já foi salvo como int, basta fazer o cast direto (int)
        if ((int)dadosValores["ctps"] != 0)
        {
            Console.Write("Ano de Contratação: ");
            dadosValores["contratação"] = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Salário: R$");
            dadosValores["salário"] = float.Parse(Console.ReadLine() ?? "0");
            
            // CORREÇÃO: Fazendo o "Unboxing" (cast) dos objetos para int antes de calcular
            int idade = (int)dadosValores["idade"];
            int contratacao = (int)dadosValores["contratação"];

            dadosValores["aposentadoria"] = idade + contratacao + 35 - anoAtual;
        }

        Console.WriteLine(string.Concat(Enumerable.Repeat("-=", 20)));
        foreach (var item in dadosValores)
        {
            Console.WriteLine($"- {item.Key} tem o valor {item.Value}");
        }
    }
}