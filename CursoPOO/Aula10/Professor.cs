namespace Aula10;
public class Professor : Pessoa
{
    public string Especialidade {get;set;} = "";
    public float Salario {get;set;}

    public void receberAumento(float aum)
    {
        Salario += aum;
    }
    public override void Status()
    {
        base.Status();
        Console.WriteLine($"especialidade: {Especialidade}");
        Console.WriteLine($"salário: {Salario}");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-==");
    }
}