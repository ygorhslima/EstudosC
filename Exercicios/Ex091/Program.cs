using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int numero;
        string resposta;
        var listaNumeros = new List<int>();

        while (true)
        {
            Console.Write("Digite um valor: ");
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Entrada inválida. Digite um número inteiro: ");
            }

            if (!listaNumeros.Contains(numero))
            {
                listaNumeros.Add(numero);
                Console.WriteLine("Valor adicionado com sucesso...");
            }
            else
            {
                Console.WriteLine("Valor duplicado! Nao vou adicionar...");
            }
            Console.Write("Quer continuar [S/N]: ");
            resposta = Console.ReadLine() ?? "";
            if (resposta?.ToUpper() == "N")
            {
                break;
            }
        }
        listaNumeros.Sort();
        Console.WriteLine($"\nVoce digitou os valores: [{string.Join(", ", listaNumeros)}]");
    }
}