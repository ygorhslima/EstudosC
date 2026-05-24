namespace Exercicios.Ex092
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> listaNumeros = [];
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.Write("Digite o valor: ");
                int valor = Convert.ToInt32(Console.ReadLine());
                listaNumeros.Add(valor);
                Console.WriteLine($"Adicionando na posição {i} da lista");
            }
            listaNumeros.Sort();
            
            Console.Write("[");
            foreach (var item in listaNumeros)
            {
                Console.Write($"{item}, ");
            }
            Console.Write("]\n");
        
        }
    }
}