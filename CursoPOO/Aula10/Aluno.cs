namespace Aula10;
public class Aluno : Pessoa
{
    public int Matricula {get;set;}
    public string Curso {get;set;} = "";

    public void CancelarMatricula()
    {
        Console.WriteLine("Matricula será cancelada");
    }

    public override void Status()
    {
        base.Status();
        Console.WriteLine($"Matricula: {Matricula}");
        Console.WriteLine($"Curso: {Curso}");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-==");
    }
}
