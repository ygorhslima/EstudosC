namespace Aula10;
public class Funcionario : Pessoa
{
    public string Setor {get;set;} = "";
    public bool Trabalhando {get;set;}
    
    public void MudarTrabalho()
    {
        Trabalhando = !Trabalhando;
    }

    public override void Status()
    {
        base.Status();
        Console.WriteLine($"Setor: {Setor}");
        Console.WriteLine($"Está trabalhando?: {Trabalhando}");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-==");
    }
}
