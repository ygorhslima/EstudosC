namespace Ex04RegistroAluno.Aluno;
public class Aluno
{
    public string Nome {get;set;} = "";
    public float Nota 
    {
        get;
        set
        {
            if(value < 0 && value > 10)
            {
                throw new ArgumentException("A nota é somente entre 0 e 10");
            }
            else
            {
                field = value;
            }
        }
    }
    public string Matricula {get;set;} = "";
}