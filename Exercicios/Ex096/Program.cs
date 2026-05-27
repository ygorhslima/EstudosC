/*
crie um programa onde o usuário possa digitar
sete valores numéricos e cadastre-os em uma lista única que mantenha separados os valores pares e ímpares. No final, mostre os valores pares e ímpares em ordem crescente
*/
class Program
{
    public static void Main(string[] args)
    {
        List<List<int>> numeros = [[], []];
        Console.WriteLine("Cadastro de números pares e ímpares: ");
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Digite o {i + 1}° valor: ");
            if (int.TryParse(Console.ReadLine(), out int valor))
            {
                if (valor % 2 == 0)
                {
                    numeros[0].Add(valor);
                }
                if (valor % 2 == 1)
                {
                    numeros[1].Add(valor);
                }
            }
            else
            {
                Console.WriteLine("Valor inválido! Digite apenas números inteiros");
                i--;
            }
        }

        numeros[0].Sort();
        numeros[1].Sort();

        Console.WriteLine($"Valores pares: [{string.Join(",", numeros[0])}]");
        Console.WriteLine($"Valores ímpares: [{string.Join(",", numeros[1])}]");
    }
}
