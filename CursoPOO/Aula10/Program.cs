using Aula10;
class Program
{
    public static void Main(string[] args)
    {
        var p1 = new Pessoa();
        var p2 = new Aluno();
        var p3 = new Professor();
        var p4 = new Funcionario();

        p1.Nome = "Pedro";
        p1.Idade = 20;
        p1.Sexo = "Masculino";
        p1.Status();
        
        p2.Nome = "Maria";
        p2.Idade = 26;
        p2.Sexo = "Feminino";
        p2.Matricula = 2141412;
        p2.Curso = "Medicina";
        p2.Status();

        p3.Nome = "Cláudio";
        p3.Idade = 50;
        p3.Sexo = "Masculino";
        p3.Especialidade = "Engenheiro Civil";
        p3.Salario = 2000;
        p3.receberAumento(500);
        p3.FazerAniver();
        p3.Status();

        p4.Nome = "Fabiana";
        p4.Idade = 40;
        p4.Sexo = "Feminino";
        p4.Setor = "Administração";
        p4.Trabalhando = true;
        p4.MudarTrabalho();
        p4.Status();
    }
}