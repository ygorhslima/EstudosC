namespace Exercicios.Ex085;

public class Program
{
    public static void Main(string[] args)
    {
        const int MAX = 5;
        string nome;
        string sexo;
        float salario;

        string[] vetor_nome = new string[MAX];
        string[] vetor_sexo = new string[MAX];
        float[] vetor_salario = new float[MAX];

        int i;
        for (i = 0; i < MAX; i++)
        {
            Console.WriteLine($"==============={i} Pessoa ===============");

            Console.Write("Nome: ");
            nome = Console.ReadLine() ?? "";

            Console.Write("Sexo [M/F]: ");
            sexo = Console.ReadLine() ?? "";

            Console.Write("Salário: R$");
            salario = float.Parse(Console.ReadLine() ?? "");

            vetor_nome[i] = nome;
            vetor_sexo[i] = sexo;
            vetor_salario[i] = salario;
        }

        Console.WriteLine("=================== DADOS DE MULHERES QUE GANHAM ACIMA DE R$5000 ===================");
        for (i = 0; i < MAX; i++)
        {
            if (vetor_sexo[i] == "F".ToUpper() && vetor_salario[i] > 5000)
            {
                Console.WriteLine($"Nome: {vetor_nome[i]}");
                Console.WriteLine($"Salário: R${vetor_salario[i]}");
            }
        }
    }
}