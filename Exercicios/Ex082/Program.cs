using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        List<float> ListaNotas = new List<float>();

        for (int i = 0; i < 10; i++)
        {
            float nota;
            bool entradaValida = false;
            do
            {
                Console.Write($"{i + 1}°a Nota: ");
                string input = Console.ReadLine() ?? "";
                
                // Tenta converter e verifica o intervalo
                if (float.TryParse(input, out nota) && nota >= 0 && nota <= 10)
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Erro: Digite uma nota válida entre 0 e 10.");
                }
            } while (!entradaValida);

            ListaNotas.Add(nota);
        }

        var mediaNota = ListaNotas.Average();
        var maiorNota = ListaNotas.Max();
        var alunosAcimaDaMedia = ListaNotas.Count(n => n > mediaNota);

        var posicoesMaiorNota = ListaNotas.Select((nota, index) => new { nota, index })
                                          .Where(x => x.nota == maiorNota)
                                          .Select(x => x.index + 1);
        
        Console.WriteLine($"\n--- Resultados ---");
        Console.WriteLine($"Média da turma: {mediaNota:F2}");
        Console.WriteLine($"Maior nota: {maiorNota}");
        Console.WriteLine($"Alunos acima da média: {alunosAcimaDaMedia}");
        Console.WriteLine($"A maior nota aparece na(s) posição(ões): {string.Join(", ", posicoesMaiorNota)}");
    }
}