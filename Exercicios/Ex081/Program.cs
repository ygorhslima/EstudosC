class Program
{
    public static void Main(string[] args)
    {
        List<int> lista_idades = [];

        for (int i = 0; i < 8; i++)
        {
            Console.Write($"Digite a idade da pessoa {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int idade))
            {
                lista_idades.Add(idade);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Tente novamente.");
                i--;
            }
        }
        
        // obtendo a media dos dados
        double media = lista_idades.Average();
        int maiorIdde = lista_idades.Max();

        Console.WriteLine($"A media de idade das pessoas cadastradas foi de {media}");

        Console.WriteLine("Idades acima de 25 anos: ");
        lista_idades
        .Select((idade, indice) => new { valor = idade, pos = indice })
        .Where(item => item.valor > 25)
        .ToList()
        .ForEach(item => Console.WriteLine($"{item.valor} na posiçao {item.pos}"));
    }
}