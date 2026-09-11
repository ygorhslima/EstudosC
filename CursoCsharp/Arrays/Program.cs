class Program
{
    static void Main()
    {
        // 1. CRIAÇÃO E INICIALIZAÇÃO
        // definindo tamanho fixo
        //int[] numeros = new int[6];
        // syntax sugar
        int[] numeros = [5, 2, 8, 1, 9, 3, 2];

        // Propriedades fundamentais
        int tamanho = numeros.Length; // Tamanho total
        int dimensoes = numeros.Rank;  // Número de dimensões (1D, 2D, etc.)

        // 2. BUSCA E LOCALIZAÇÃO
        int primeiroIndice = Array.IndexOf(numeros, 2);      // Retorna 1 (primeira ocorrência)
        int ultimoIndice = Array.LastIndexOf(numeros, 2);    // Retorna 6 (última ocorrência)
        int primeiroMaiorQue4 = Array.Find(numeros, x => x > 4); // Retorna 5 (busca por predicado)
        int[] todosMaioresQue4 = Array.FindAll(numeros, x => x > 4); // Retorna [5, 8, 9]
        bool existePar = Array.Exists(numeros, x => x % 2 == 0);     // Retorna true
        bool todosPositivos = Array.TrueForAll(numeros, x => x > 0); // Retorna true

        // 3. ORDENAÇÃO E INVERSÃO
        Array.Sort(numeros); // Ordena in-place via IntroSort (O(N log N)) -> [1, 2, 2, 3, 5, 8, 9]

        // Busca Binária (requer array previamente ordenado - O(log N))
        int indiceBinary = Array.BinarySearch(numeros, 8); // Retorna o índice do elemento 8

        Array.Reverse(numeros); // Inverte a ordem in-place -> [9, 8, 5, 3, 2, 2, 1]

        // 4. CÓPIA E CLONAGEM (Base para expansão de estruturas dinâmicas)
        int[] destino = new int[numeros.Length];
        Array.Copy(numeros, destino, numeros.Length); // Cópia de alta performance por bloco de memória

        int[] clone = (int[])numeros.Clone(); // Cria uma nova instância de array idêntica

        // 5. REDIMENSIONAMENTO (Base interna da List<T>)
        // Cria um novo array com tamanho 10, copia os dados antigos e atualiza a referência
        Array.Resize(ref numeros, 10);

        // 6. LIMPEZA DE ELEMENTOS
        // Reseta 3 elementos a partir do índice 0 para o valor padrão do tipo (0 para int, null para objetos)
        Array.Clear(numeros, 0, 3);

        // 7. INTEGRAÇÃO COM LINQ (Ponte para outras coleções)
        var lista = numeros.ToList();                     // Converte Array -> List<T>
        var filtrados = numeros.Where(n => n > 2).ToArray(); // Cria novo array filtrado
    }
}