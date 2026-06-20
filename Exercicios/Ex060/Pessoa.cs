namespace Exercicios.Ex060;
public class Pessoa
{
    public string Nome { get; set; } = "";
    public int Idade { get; set; }
    public string Sexo { get; set; } = "";

    public void ToString()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Sexo: {Sexo}");
    }
}