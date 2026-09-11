using System;

class Program
{
    static void Main()
    {
        string nome = "Maria";
        double preco = 1234.567;
        double porcentagem = 0.155;
        int id = 42;
        DateTime agora = DateTime.Now;

        // 1. Interpolação de String ($) - Forma moderna e recomendada
        string interpolacao = $"Cliente: {nome} | ID: {id:D5}";

        // 2. Formatação Composta (String.Format)
        string composta = string.Format("Cliente: {0} | Preço: {1:C}", nome, preco);

        // 3. Formatação Numerica Avançada
        Console.WriteLine("=== Formatação de Números ===");
        Console.WriteLine($"Moeda (C):          {preco:C}");        // Ex: R$ 1.234,57 (depende da cultura)
        Console.WriteLine($"Casas Decimais (F2):{preco:F2}");       // 1234.57
        Console.WriteLine($"Milhares (N2):      {preco:N2}");       // 1.234,57
        Console.WriteLine($"Porcentagem (P1):   {porcentagem:P1}"); // 15,5%
        Console.WriteLine($"Hexadecimal (X4):   {id:X4}");          // 002A

        Console.WriteLine("\n=== Formatação de Data e Hora ===");
        Console.WriteLine($"Data Curta (d):     {agora:d}");                  // 11/09/2026
        Console.WriteLine($"Data Extensa (D):   {agora:D}");                  // sexta-feira, 11 de setembro de 2026
        Console.WriteLine($"Personalizada:      {agora:dd/MM/yyyy HH:mm:ss}"); // 11/09/2026 14:30:00

        Console.WriteLine("\n=== Alinhamento e Espaçamento (Padding) ===");
        // Valores negativos alinham à esquerda; positivos alinham à direita
        Console.WriteLine($"| {"Produto",-12} | {"Qtd",5} | {"Preço",10} |");
        Console.WriteLine($"| {"Teclado",-12} | {2,5} | {150.00,10:C} |");
        Console.WriteLine($"| {"Mouse Pad",-12} | {10,5} | {25.50,10:C} |");
    }
}