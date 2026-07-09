using Ex05GestaoFuncionarios.Interface;

namespace Ex05GestaoFuncionarios
{
    public class FuncoesMenu : IFuncoesMenu
    {
        public void Menu()
        {
            Lin("-=");
            Console.WriteLine("[0] Sair do programa");
            Console.WriteLine("[1] Cadastrar gerente");
            Console.WriteLine("[2] Cadastrar designer");
            Console.WriteLine("[3] Visualizar todos os dados");
            Console.WriteLine("[4] Buscar por matrícula");
            Console.WriteLine("[5] Remover funcionário");
            Lin("-=");
        }

        public void Lin(string tipoLinha)
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat($"{tipoLinha}", 20)));
        }

        public void CadastrarGerente(List<Funcionario> funcionarios)
        {
            string resposta = "S";
            while (resposta != "N")
            {
                Console.WriteLine("[Novo cadastro: Gerente]");
                Console.Write("Matricula: ");
                string matricula = Console.ReadLine() ?? "";

                Console.Write("Nome: ");
                string nome = Console.ReadLine() ?? "";

                Console.Write("Salário Base: ");
                decimal salariobase = decimal.Parse(Console.ReadLine() ?? "");

                Console.Write("Bônus: ");
                decimal bonus = decimal.Parse(Console.ReadLine() ?? "");

                var gerente = new Gerente(matricula, nome, salariobase, bonus);
                funcionarios.Add(gerente);

                Console.Write("quer continuar? [S/N]: ");
                resposta = Console.ReadLine() ?? "";

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Gerente cadastrado com sucesso!");
                Console.ResetColor();
            }
        }

        public void CadastrarDesigner(List<Funcionario> funcionarios)
        {
            string resposta = "S";
            while (resposta != "N")
            {
                Console.WriteLine("[Novo cadastro: Designer]");

                Console.Write("Matricula: ");
                string matricula = Console.ReadLine() ?? "";

                Console.Write("Nome: ");
                string nome = Console.ReadLine() ?? "";

                Console.Write("Salário Base: ");
                decimal salariobase = decimal.Parse(Console.ReadLine() ?? "");

                Console.Write("Ferramenta principal");
                string ferramentaPrincipal = Console.ReadLine() ?? "";

                var designer = new Designer(matricula, nome, salariobase, ferramentaPrincipal);
                funcionarios.Add(designer);

                Console.Write("quer continuar? [S/N]: ");
                resposta = Console.ReadLine() ?? "";

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Designer cadastrado com sucesso!");
                Console.ResetColor();
            }
        }

        public void VisualizarTodos(List<Funcionario> funcionarios)
        {
            if (funcionarios.Count == 0)
            {
                Console.WriteLine("Nenhum funcionário encontrado...");
                return;
            }

            Console.WriteLine("------ LISTA DE FUNCIONÁRIOS ----");
            foreach (var func in funcionarios)
            {
                Lin("*=");
                Console.WriteLine($"Matricula: {func.Matricula}");
                Console.WriteLine($"Nome: {func.Nome}");
                Console.WriteLine($"Salário base: {func.SalarioBase}");

                if (func is Gerente gerente)
                {
                    Console.WriteLine($"Bonus: {gerente.Bonus}");
                }

                if (func is Designer designer)
                {
                    Console.WriteLine($"Ferramenta Principal: {designer.FerramentaPrincipal}");
                }
                Lin("*=");
            }
        }
        
        public void BuscarPorMatricula(List<Funcionario> funcionarios)
        {
            if (funcionarios.Count == 0)
            {
                Console.WriteLine("Nenhum funcionário encontrado...");
                return;
            }
            else
            {
                Console.Write("Digite a matricula: ");
                string entrada = Console.ReadLine() ?? "";
                var listaAtualizada = funcionarios.Where(f => f.Matricula == entrada).ToList();
                VisualizarTodos(listaAtualizada);
            }
        }
        
        public void RemoverFuncionario(List<Funcionario> funcionarios)
        {

            if (funcionarios.Count == 0)
            {
                Console.WriteLine("ERRO: Lista vazia, não é possível remover funcionários");
            }
            else
            {
                Console.Write("Digite a matricula do funcionário: ");
                string m = Console.ReadLine() ?? "";
                var funcionarioParaRemover = funcionarios.FirstOrDefault(f => f.Matricula == m);
                if(funcionarioParaRemover != null)
                {
                    funcionarios.Remove(funcionarioParaRemover);
                    Console.WriteLine($"Sucesso: O funcionário {funcionarioParaRemover.Nome} foi removido do banco de dados");
                }
            }
        }
    }
}