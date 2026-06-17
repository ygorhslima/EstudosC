class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Sistema de Analise de Emprestimo ---");
        Console.Write("Valor da casa: R$");
        var valorCasa = float.Parse(Console.ReadLine() ?? "");
        
        Console.Write("Salário do comprador: R$");
        var salario = float.Parse(Console.ReadLine() ?? "");
        
        Console.Write("Quantidade de anos para pagar: ");
        var anos = int.Parse(Console.ReadLine() ?? "");
        
        var meses = anos * 12;
        var prestacao = valorCasa / meses;
        Console.WriteLine("--- Resultado ---");
        Console.WriteLine($"Para pagar uma casa de R${valorCasa} em {anos} anos");
        Console.WriteLine($"A prestação será de R${prestacao} mensais");
        if (prestacao <= (salario * 0.30))
        {
            Console.WriteLine("SITUAÇÃO: Empréstimo APROVADO!");
        }
        else
        {
            Console.WriteLine("SITUAÇÃO: Empréstimo NEGADO!");
            Console.WriteLine($"Motivo: A parcela excede 30% do seu salário (R$ {salario * 0.30})");
        }
    }    
}