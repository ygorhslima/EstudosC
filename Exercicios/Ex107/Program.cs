/*
Faça um programa que tenha uma função chamada area(), que recebe as dimensões de um terreno retângular (largura e comprimento) e mostre a área do terreno
*/

namespace Exercicios.Ex107;

public class Program
{
    static float Area(float largura, float comprimento)
    {
        return largura * comprimento;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Controle de terrenos: ");
        Console.Write("Largura (m): ");
        float larg = float.Parse(Console.ReadLine() ?? "");
        
        Console.Write("Comprimento (m): ");
        float compri = float.Parse(Console.ReadLine() ?? "");

        float calc = Area(larg, compri);
        Console.WriteLine($"A área de um terreno {larg}x{compri}");
    }
}