namespace Aula10;
public class Pessoa
{
    public string Nome { get; set; } = "";
    public int Idade { get; set; }
    public string Sexo { get; set; } = "";

    public void FazerAniver()
    {
        Console.WriteLine("Fazendo aniversário");
        Idade++;
    }

    public virtual void Status()
    {
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-==");
        Console.WriteLine($"nome: {Nome}");
        Console.WriteLine($"idade: {Idade}");
        Console.WriteLine($"sexo: {Sexo}");
    }
}
