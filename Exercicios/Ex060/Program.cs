namespace Exercicios.Ex060;

public class Program
{
    public static void Main(string[] args)
    {
        var ListaPessoas = new List<Pessoa>();
        string resposta = "S";
        do
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine() ?? "";

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine() ?? "");

            Console.Write("Sexo [M/F]: ");
            string sexo = Console.ReadLine() ?? "";

            ListaPessoas.Add(new Pessoa { Nome = nome, Idade = idade, Sexo = sexo });

            Console.Write("Quer continuar [S/N]: ");
            resposta = Console.ReadLine() ?? "";
        } while (resposta != "N".ToUpper());

        if (ListaPessoas.Count > 0)
        {
            var pessoaMaisVelha = ListaPessoas
            .OrderByDescending(pessoa => pessoa.Idade)
            .First();

            var mulherMaisJovem = ListaPessoas
            .Where(pessoa => pessoa.Sexo == "F")
            .OrderBy(pessoa => pessoa.Idade)
            .FirstOrDefault();

            double MediaIdade = ListaPessoas.Average(pessoa => pessoa.Idade);

            int homensMais30 = ListaPessoas.Count(pessoa =>
                pessoa.Sexo == "M" &&
                pessoa.Idade > 30
            );

            int mulheresMenos18 = ListaPessoas.Count(pessoa =>
                pessoa.Sexo == "F" &&
                pessoa.Idade < 18
            );

            Console.WriteLine("================ RESULTADOS OBTIDOS ================");
            Console.WriteLine($"Pessoa mais velha: {pessoaMaisVelha.Nome} ({pessoaMaisVelha.Idade} anos)");

            if (mulherMaisJovem != null)
            {
                Console.WriteLine($"Mulher mais jovem: {mulherMaisJovem.Nome} ({mulherMaisJovem.Idade} anos)");
            }
            else
            {
                Console.WriteLine("Nenhuma mulher foi cadastrada no grupo");
            }

            Console.WriteLine($"A média de idade do grupo é de {MediaIdade} anos");
            Console.WriteLine($"Quantidade de homens que tem mais de 30 anos: {homensMais30}");
            Console.WriteLine($"Quantidade de mulheres que tem menos de 18 anos: {mulheresMenos18}");
        }
    }
}