class Program
{
    static void FuncaoLinha(string tipoLinha, int quantidade)
    {
        Console.WriteLine(string.Concat(Enumerable.Repeat(tipoLinha,quantidade)));
    }
    static void Main()
    {
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2,5]
        {
            {11,22,00,44,55},
            {66,77,88,99,00}
        };
        
        // testando valores Preenchendo o vetor 1 com valores aleatórios
        Random random = new Random();
        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i] = random.Next(50);
        }
        
        Console.WriteLine("Elementos do vetor1: ");
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }
        
        //BinarySearch: Retorna a posição do elemento que está sendo procurado
        Console.WriteLine("BinarySearch");
        int procurado = 33;
        int posicao = Array.BinarySearch(vetor1, procurado);
        Console.WriteLine($"Valor {procurado} está na posição {posicao}");
        FuncaoLinha("-=",20);
        
        //Copy(Ar_origem, Ar_destino, quantidade_de_elementos)
        Console.WriteLine("Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach (var n in vetor2)
        {
            Console.WriteLine(n);
        }
        FuncaoLinha("-=", 20);
        
        //CopyTo(Ar_destino, a_partir_desta_posicao)
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3, 0);
        foreach (var n in vetor3)
        {
            Console.WriteLine(n);
        }
        FuncaoLinha("-=", 20);
        
        int[] numeros = { 45, 12, 89, 23, 12, 67, 34 };

        // 1. Sort: Ordena os elementos em ordem crescente
        Console.WriteLine("Array.Sort");
        Array.Sort(numeros);
        Console.WriteLine("Ordenado: " + string.Join(", ", numeros));
        FuncaoLinha("-=", 20);

        // 2. Reverse: Inverte a ordem atual dos elementos
        Console.WriteLine("Array.Reverse");
        Array.Reverse(numeros);
        Console.WriteLine("Invertido: " + string.Join(", ", numeros));
        FuncaoLinha("-=", 20);

        // 3. IndexOf e LastIndexOf: Busca posições por valor exato
        Console.WriteLine("IndexOf / LastIndexOf");
        int primeiro12 = Array.IndexOf(numeros, 12);
        int ultimo12 = Array.LastIndexOf(numeros, 12);
        Console.WriteLine($"Primeira ocorrência do 12: índice {primeiro12}");
        Console.WriteLine($"Última ocorrência do 12: índice {ultimo12}");
        FuncaoLinha("-=", 20);

        // 4. Find e FindAll: Busca elementos via Expressão Lambda (Predicado)
        Console.WriteLine("Find / FindAll");
        int primeiroMaiorQue50 = Array.Find(numeros, n => n > 50);
        int[] todosMaioresQue30 = Array.FindAll(numeros, n => n > 30);
        Console.WriteLine($"Primeiro valor > 50: {primeiroMaiorQue50}");
        Console.WriteLine($"Todos os valores > 30: " + string.Join(", ", todosMaioresQue30));
        FuncaoLinha("-=", 20);

        // 5. Exists e TrueForAll: Validações booleanas
        Console.WriteLine("Exists / TrueForAll");
        bool existePar = Array.Exists(numeros, n => n % 2 == 0);
        bool todosPositivos = Array.TrueForAll(numeros, n => n > 0);
        Console.WriteLine($"Existe algum número par? {existePar}");
        Console.WriteLine($"Todos são maiores que zero? {todosPositivos}");
        FuncaoLinha("-=", 20);

        // 6. Fill: Preenche todo o array com um valor padrão
        Console.WriteLine("Array.Fill");
        int[] vetorPreenchido = new int[5];
        Array.Fill(vetorPreenchido, 99);
        Console.WriteLine("Vetor preenchido: " + string.Join(", ", vetorPreenchido));
        FuncaoLinha("-=", 20);

        // 7. Clear: Redefine valores de um intervalo para o padrão do tipo (0 para int)
        Console.WriteLine("Array.Clear");
        Array.Clear(numeros, 0, 3); // Zera 3 elementos a partir do índice 0
        Console.WriteLine("Após zerar os 3 primeiros: " + string.Join(", ", numeros));
        FuncaoLinha("-=", 20);

        // 8. Resize: Altera a capacidade do array (cria uma nova instância internamente)
        Console.WriteLine("Array.Resize");
        Array.Resize(ref numeros, 10); // Redimensiona para tamanho 10
        Console.WriteLine($"Novo tamanho: {numeros.Length}");
        Console.WriteLine("Array expandido: " + string.Join(", ", numeros));
        FuncaoLinha("-=", 20);
    }
}