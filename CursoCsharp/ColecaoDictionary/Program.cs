class Program
{
    public static void Main(string[] args)
    {
        // sintaxe tradicional
        /*
        Dictionary<int, string> veiculos = new()
        {
            {10, "Carro"},
            {5, "Aviao"},
            {0, "Navio"},
            {20, "Moto"},
            {15, "Carro"}
        };
        */

        // sintaxe com indexadores
        Dictionary<int, string> veiculos = new()
        {
            [10] = "Carro",
            [5] = "Aviao",
            [0] = "Navio",
            [20] = "Moto",
            [15] = "Carro"
        };

        veiculos.Add(90, "Caminhão");
        int chave = 5;
        string valor = "Aviao";
        if (veiculos.ContainsKey(chave))
        {
            Console.WriteLine($"A chave {chave} está na coleção");
        }
        else
        {
            Console.WriteLine($"A chave {chave} não está na coleção");
        }

        if (veiculos.ContainsValue(valor))
        {
            Console.WriteLine($"O valor {valor} está na coleção");
        }
        else
        {
            Console.WriteLine($"O valor {valor} não está na coleção");
        }

        foreach (KeyValuePair<int, string> v in veiculos)
        {
            Console.WriteLine($"{v.Key} - {v.Value}");
        }
    }
}