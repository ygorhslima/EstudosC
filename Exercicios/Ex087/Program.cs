using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Lista já inserida na ordem do 1º ao 20º lugar de 2025
        var listaTimesBrasileirao2025 = new List<string>
        {
            "Flamengo", "Palmeiras", "Cruzeiro", "Mirassol", "Fluminense",
            "Botafogo", "Bahia", "São Paulo", "Grêmio", "Bragantino",
            "Atlético-MG", "Santos", "Corinthians", "Vasco da Gama", "EC Vitória",
            "Internacional", "Ceará SC", "Fortaleza", "Juventude", "Sport Recife"
        };

        Console.WriteLine("Classificação Final Brasileirão 2025:");
        listaTimesBrasileirao2025.ForEach(time => Console.WriteLine(time));

        Console.WriteLine("\nOs 5 primeiros (G5):");
        listaTimesBrasileirao2025.Take(5).ToList().ForEach(time => Console.WriteLine(time));

        Console.WriteLine("\nOs 4 últimos (Rebaixados):");
        listaTimesBrasileirao2025.TakeLast(4).ToList().ForEach(time => Console.WriteLine(time));

        Console.WriteLine("\nTimes em ordem alfabética:");
        // Usando LINQ para ordenar alfabeticamente sem alterar a lista original
        var timesAlfabeticos = listaTimesBrasileirao2025.OrderBy(t => t).ToList();
        timesAlfabeticos.ForEach(time => Console.WriteLine(time));
    }
}