public class Program
{
    public static void Main(string[] args)
    {
        string texto = "  Olá, Mundo do C#!   ";
        string textoVazio = "";
        string textoNulo = null;

        // 1. Inspeção e Busca
        Console.WriteLine($"""
        === INSPEÇÃO E BUSCA ===
        -> é nulo ou vazio?: {string.IsNullOrEmpty(textoVazio)}
        -> é nulo ou tem espaços em branco?: {string.IsNullOrWhiteSpace("  ")}
        -> Contêm a palavra \"mundo\" no texto?: {texto.Contains("Mundo")}
        -> Começa com Olá?: {texto.Trim().StartsWith("Olá")}
        -> Termina com exclamação(!) ?: {texto.Trim().EndsWith("!")}
        -> Qual a primeira posição em que se encontra a letra 'M'?: {texto.IndexOf('M')}
        -> Qual a última posição em que se encontra a letra 'o'?: {texto.LastIndexOf('o')}
        """);

        string limpo = texto.Trim();
        Console.WriteLine($"""
        === MODIFICAÇÃO E TRANSFORMAÇÃO ===
        tirando espaços: '{limpo}'
        tirando espaço no início: '{texto.TrimStart()}'
        tirando Espaço no fim: '{texto.TrimEnd()}'
        Maiúsculo: {limpo.ToUpper()}
        Minúsculo: {limpo.ToLower()}
        Substituindo Mundo para Desenvolvedor: {limpo.Replace("Mundo", "Desenvolvedor")}
        Substring: {limpo.Substring(5, 5)}
        Caracteres a mais à esquerda: {limpo.PadLeft(25, '*')}
        Caracteres a mais à direita: {limpo.PadRight(25, '*')}
        """);

        Console.WriteLine("\n=== DIVISÃO E JUNÇÃO ===");
        string linguagensCsv = "C#,Java,Python,TypeScript";
        string[] arrayLinguagens = linguagensCsv.Split(',');
        Console.WriteLine($"Split (primeiro elemento): {arrayLinguagens[0]}");

        string textoJuntado = string.Join(" | ", arrayLinguagens);
        Console.WriteLine($"string.Join: {textoJuntado}");

        // 4. Comparação
        Console.WriteLine("\n=== COMPARAÇÃO ===");
        string palavraA = "csharp";
        string palavraB = "CSHARP";
        Console.WriteLine($"Equals (ignorando case): {palavraA.Equals(palavraB, StringComparison.OrdinalIgnoreCase)}");
        Console.WriteLine($"string.Compare: {string.Compare("Ana", "Bia")}");

        // 5. Concatenação e Formatação
        Console.WriteLine("\n=== CONCATENAÇÃO E FORMATAÇÃO ===");
        string usuario = "Carlos";
        int pontos = 150;

        Console.WriteLine($"Interpolação ($): Usuário {usuario} possui {pontos} pontos.");
        Console.WriteLine(string.Format("string.Format: Usuário {0} possui {1} pontos.", usuario, pontos));
        Console.WriteLine(string.Concat("string.Concat: ", usuario, " ganho de pontos: ", pontos));
    }
}