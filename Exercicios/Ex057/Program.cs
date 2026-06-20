namespace Exercicios.Ex057;

class Program
{
    public static void Main(string[] args)
    {
        var ListaFuncionarios = new List<Funcionario>();
        string resposta = "S";

        do
        {
            var funcionario = new Funcionario();

            Console.Write("Salário: R$");
            funcionario.Salario = float.Parse(Console.ReadLine() ?? "");
            
            Console.Write("Sexo: [M/F]");
            funcionario.Sexo = (Console.ReadLine() ?? "").ToUpper();
            
            ListaFuncionarios.Add(funcionario);

            Console.Write("Quer continuar? [S/N]: ");
            resposta = (Console.ReadLine() ?? "").ToUpper();

        } while (resposta != "N");
        ProcessarResultados(ListaFuncionarios);
    }

    private static void ProcessarResultados(List<Funcionario> funcionarios)
    {
        float totHomens = 0;
        float totMulheres = 0;
        foreach (var f in funcionarios)
        {
            if (f.Sexo == "M".ToUpper()) totHomens += f.Salario;
            if (f.Sexo == "F".ToUpper()) totMulheres += f.Salario;
        }
        Console.WriteLine("=================== RESULTADO ====================");
        Console.WriteLine($"O total de salários pago dos homens foi: R${totHomens}");
        Console.WriteLine($"O total de salários pago das mulheres foi: R${totMulheres}");
    }
}