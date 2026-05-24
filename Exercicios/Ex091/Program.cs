/*
Crie um programa onde o usuário possa digitar vários valores numéricos e cadastre-os em uma lista. Caso o número já existia lá dentro, ele não será adicionado. no Final, serão exibidos todos os valores únicos digitados, em ordem crescente

Digite um valor: 6
valor adicionado com sucesso...
Quer continuar: [S/N] s
Digite um valor: 9
valor adicionado com sucesso...
Quer continuar: [S/N] s
Digite um valor: 6
Valor duplicado! Não vou adicionar...
Quer continuar: [S/N] s
Digite um valor: 1
valor adicionado com sucesso...
Quer continuar: [S/N] n

vocÊ digitou os valores [1,6,9]
*/
using System.Runtime.InteropServices;

namespace Exercicio.Ex091
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();
            char resposta = 'S';
            while (resposta != 'N' && resposta != 'n')
            {
                Console.WriteLine("Digite um valor: ");
                int valor = Convert.ToInt32(Console.ReadLine());

                if (!listaNumeros.Contains(valor))
                {
                    listaNumeros.Add(valor);
                    Console.WriteLine("Valor Adicionado com sucesso...");
                }
                else
                {
                    Console.WriteLine("Valor duplicado! Não vou adicionar...");
                }

                Console.WriteLine("Quer Continuar [S/N]: ");
                resposta = Console.ReadLine()[0];
            }
            listaNumeros.Sort();
            Console.WriteLine($"\nvocê digitou os valores {string.Join(',', listaNumeros)}");
        }
    }
}