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
        PadLeft: {limpo.PadLeft(25, '*')}
        PadRight: {limpo.PadRight(25, '*')}
        """);
    }
}