using Ex04RegistroAluno.Aluno;

public class FuncoesMenuAlunos : IFuncoesMenuAlunos
{
    public void AdicionarAlunos(List<Aluno> alunos)
    {
        string resposta = "S";
        while (resposta != "N")
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine() ?? "";

            Console.Write("Nota: ");
            float nota = float.Parse(Console.ReadLine() ?? "");

            Console.Write("Matricula: ");
            string matricula = Console.ReadLine() ?? "";

            alunos.Add(new Aluno
            {
                Nome = nome,
                Nota = nota,
                Matricula = matricula
            });

            Console.Write("Quer continuar [S/N]: ");
            resposta = Console.ReadLine() ?? "";
        }
    }


    public void BuscarTodosAlunos(List<Aluno> alunos)
    {
        if (alunos.Count == 0)
        {
            Console.WriteLine("ERRO: lista está vazia");
        }
        else
        {
            foreach (var item in alunos)
            {
                Lin("-=");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Nota: {item.Nota}");
                Console.WriteLine($"Matricula: {item.Matricula}");
                Lin("-=");
            }
        }
    }


    public void Menu()
    {
        Lin("-=");
        Console.WriteLine("[0] Sair do Programa");
        Console.WriteLine("[1] Adicionar um novo aluno");
        Console.WriteLine("[2] Visualizar todos os alunos");
        Console.WriteLine("[3] buscar um aluno");
        Console.WriteLine("[4] Editar dados de um aluno");
        Console.WriteLine("[5] Remover um aluno do banco");
        Lin("-=");
    }

    public void Lin(string TipoLinha)
    {
        Console.WriteLine(string.Concat(Enumerable.Repeat($"{TipoLinha}", 20)));
    }

    public void EditarAluno(List<Aluno> alunos)
    {
        if (alunos.Count == 0)
        {
            Console.WriteLine("ERRO: Lista vazia, não é possível editar aluno");
        }
        else
        {
            Console.Write("Digite o número de matricula do aluno que deseja editar: ");
            string m = Console.ReadLine() ?? "";
            // encontro o aluno a partir da matricula, encontrando o primeiro aluno que tenha a mesma matricula digitado pelo usuário
            var alunoEncontrado = alunos.FirstOrDefault(a => a.Matricula == m);
            if (alunoEncontrado != null)
            {
                Console.WriteLine($"Editando aluno: {alunoEncontrado.Nome}");

                Console.Write("Novo Nome: ");
                string novoNome = Console.ReadLine() ?? "";
                if (!string.IsNullOrWhiteSpace(novoNome)) alunoEncontrado.Nome = novoNome;

                Console.Write("Nova Nota: ");
                string entrada = Console.ReadLine() ?? "";
                if (float.TryParse(entrada, out float novaNota)) alunoEncontrado.Nota = novaNota;

                Console.WriteLine("Aluno atualizado com sucesso");
            }
            else
            {
                Console.WriteLine("ERRO! não foi encontrado este aluno com essa matricula");
            }
        }
    }

    public void RemoverAluno(List<Aluno> alunos)
    {
        if (alunos.Count == 0)
        {
            Console.WriteLine("ERRO: Lista vazia, não é possível remover aluno");
        }
        else
        {
            Console.WriteLine("Qual o número de matricula do aluno que não está mais na escola?: ");
            string m = Console.ReadLine() ?? "";
            var alunoParaRemover = alunos.FirstOrDefault(a => a.Matricula == m);
            if (alunoParaRemover != null)
            {
                alunos.Remove(alunoParaRemover);
                Console.WriteLine($"Sucesso: O aluno {alunoParaRemover.Nome} foi removido do banco de dados");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado");
            }
        }
    }

    public void BuscarAluno(List<Aluno> alunos)
    {
        if (alunos.Count == 0)
        {
            Console.WriteLine("ERRO: Lista vazia, não é possível buscar dados");
        }
        else
        {
            Lin("-=");
            Console.Write("Digite o número da matrícula do aluno: ");
            string m = Console.ReadLine() ?? "";
            // verificando se a matricula da lista alunos é igual a matricula que o usuário digitou
            var listaAtualizada = alunos.Where(a => a.Matricula == m).ToList();
            BuscarTodosAlunos(listaAtualizada);
        }
    }
}