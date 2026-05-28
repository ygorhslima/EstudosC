/*
Exercício Python 087: Aprimore o desafio anterior, mostrando no final: 
A) A soma de todos os valores pares digitados.
B) A soma dos valores da terceira coluna.
C) O maior valor da segunda linha.
*/
class Program
{
    static void Lin()
    {
        Console.WriteLine(string.Concat(Enumerable.Repeat("-=", 20)));
    }
    public static void Main(string[] args)
    {
        int[,] matriz = new int[3, 3];
        int somaPares = 0;
        int somaColuna = 0;
        int maiorLinha2 = 0;

        Console.WriteLine("Digite os valores para preencher a matriz 3x3");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Digite um valor para [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine() ?? "");

                if (matriz[i, j] % 2 == 0)
                {
                    somaPares += matriz[i, j];
                }
                somaColuna += matriz[i, 2];

                if (matriz[1, j] > maiorLinha2)
                {
                    maiorLinha2 = matriz[1, j];
                }
            }
        }
        Lin();
        Console.WriteLine("MATRIZ RESULTANTE");
        Lin();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($" [ {matriz[i, j]} ] ");
            }
            Console.WriteLine();
        }
        Lin();
        Console.WriteLine($"A soma de todos os valores pares digitados foram: {somaPares}");
        Console.WriteLine($"A soma dos valores da terceira coluna: {somaColuna}");
        Console.WriteLine($"O maior valor da segunda linha: {maiorLinha2}");
    }
}