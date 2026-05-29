/*
Crie um programa que crie uma matriz de dimensão 3x3 e preencha com valores lido pelo teclado.
No final, mostre a matriz na tela, com formatação correta.
*/

namespace Exercicios.Ex097;
public class Program
{
    static void Lin()
    {
        Console.WriteLine(string.Concat(Enumerable.Repeat("-=",20)));
    }
    public static void Main(string[] args)
    {
        int [,] matriz = new int[3,3];
        Console.WriteLine("Digite os valores para preencher a matriz 3x3");
        for(int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Digite um valor para [{i},{j}]: ");
                matriz[i,j] = int.Parse(Console.ReadLine() ?? "");
            }
        }
        Lin();
        Console.WriteLine("MATRIZ RESULTANTE");
        Lin();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($" [ {matriz[i,j]} ] ");
            }
            Console.WriteLine();
        }
        Lin();
    }
}